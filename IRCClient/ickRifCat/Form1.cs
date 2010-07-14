using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using ParseMessage;
using Gt.ParserLibrary.Writers;

namespace ickRifCat
{
	public partial class Form1 : Form, IWriter
	{
		private TcpClient _client ;
		ConnectionInfo _connection;
		string _channel;

		ConnectionInfo GetConnectionInfo()
		{
			if ( String.IsNullOrEmpty( _serverName.Text ) || String.IsNullOrEmpty( _port.Text ) )
			{
				ServerConnection connDlg = new ServerConnection();

				if ( connDlg.ShowDialog( this ) != DialogResult.OK )
				{
					return null;
				}

				_connection = new ConnectionInfo()
				{
					HostName = connDlg.ServerName,
					HostPort = connDlg.Port,
				};

				return _connection;
			}

			return new ConnectionInfo() { HostName = _serverName.Text, HostPort = int.Parse( _port.Text ) };
		}

		ConnectionInfo GetUserInfo()
		{
			if ( String.IsNullOrEmpty( _userName.Text ) || String.IsNullOrEmpty( _password.Text ) || String.IsNullOrEmpty( _nickname.Text ) )
			{
				UserInfo dlgInfo = new UserInfo();

				if ( dlgInfo.ShowDialog( this ) == DialogResult.OK )
				{
					return new ConnectionInfo()
					{
						Username = dlgInfo.UserName
						,
						Password = dlgInfo.Password,
						Nickname = dlgInfo.NickName
					};
				}
			}
			return new ConnectionInfo() { Username = _userName.Text, Password = _password.Text, Nickname = _nickname.Text } ;

		}

		ConnectionInfo GetChannel()
		{
			if ( String.IsNullOrEmpty( _channelName.Text ) )
				return new ConnectionInfo() { Channel = "#shamwow" };

			return new ConnectionInfo() { Channel = _channelName.Text };
		}

		void Message( string title, string msg )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new MethodInvoker( delegate { Message( title, msg ); } ) );
			}
			else
			{
				if ( richTextBox1 != null && !richTextBox1.IsDisposed )
				{
					richTextBox1.SelectionStart = richTextBox1.TextLength;
					richTextBox1.SelectionLength = 0;

					if ( !String.IsNullOrEmpty( title ) )
					{
						int[] tabs = new int[] { maxWidth + 2 };

						richTextBox1.SelectionHangingIndent = tabs[ 0 ];
						richTextBox1.SelectionTabs = tabs;

						msg = title + "\t" + msg;
					}

					richTextBox1.SelectedText = msg + "\r\n";
					richTextBox1.ScrollToCaret();
				}
			}
		}

		void Message(string msg)
		{
			Message( null, msg );
		}

		void Debug( string msg )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new MethodInvoker( delegate { Debug( msg ); } ) );
			}
			else
			{
				_debug.SelectionStart = _debug.TextLength;
				_debug.SelectionLength = 0;
				_debug.SelectedText = msg + "\r\n";
				_debug.ScrollToCaret();
			}
		}

		private bool ConnectToServer()
		{
			ConnectionInfo c = GetConnectionInfo();

			try
			{
				if ( c != null )
				{
					_client.Connect( c.HostName, c.HostPort );

					_serverName.Text = c.HostName;
					_port.Text = c.HostPort.ToString();

					msgReader.RunWorkerAsync();

					return true;
				}
			}
			catch ( SocketException sX)
			{
				MessageBox.Show( String.Format( "Unable to connect to {0}:{1} {2}", c.HostName, c.HostPort, sX.Message ) );
			}

			return false;

		}

		public Form1()
		{
			InitializeComponent();
			_client = new TcpClient();
		}

		private void SendMsgToServer(string msg)
		{
			byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(
				string.Format("{0}\r\n", msg)
				);

			if ( _client.Connected )
				_client.GetStream().Write( b, 0, b.Length );
			else
				Message( "ERROR", String.Format( "Can't send message, connection closed {0}", msg ) );
		}

		private void EnableInfoControls( bool enabled )
		{
			button1.Enabled = enabled ;
			_channelName.Enabled =  enabled ;
			_nickname.Enabled = enabled;
			_password.Enabled = enabled;
			_userName.Enabled = enabled;
			_serverName.Enabled = enabled;
			_port.Enabled = enabled;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ( ConnectToServer() )
			{
				ConnectionInfo userInfo = GetUserInfo();

				if ( _client.GetStream().CanWrite )
				{
					SendMsgToServer( string.Format( "PASS {0}", userInfo.Password ) );
				}

				if ( _client.GetStream().CanWrite )
				{
					SendMsgToServer( string.Format( "NICK {0}", userInfo.Nickname ) );
				}

				if ( _client.GetStream().CanWrite )
				{
					SendMsgToServer( string.Format( "USER {0} 0 * :{1}", userInfo.Username, userInfo.Username ) );
				}

				if ( _client.GetStream().CanWrite )
				{
					SendMsgToServer( string.Format( "JOIN {0}", GetChannel().Channel ) );
				}

				_userName.Text = userInfo.Username;
				_password.Text = userInfo.Password;
				_channel = _channelName.Text = GetChannel().Channel;

				EnableInfoControls( false ) ;
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (textBox1.TextLength > 0)
				{
					Message("[Me]", textBox1.Text);

					SendMsgToServer(string.Format("PRIVMSG {0} :{1}", _channel, textBox1.Text));
					textBox1.Text = "";
					e.Handled = true;
				}
			}

		}

		private void msgReader_DoWork(object sender, DoWorkEventArgs e)
		{
			IrcMsg irc = new IrcMsg();

			irc.Output = this;

			irc.MessageRecievedEvent += new ParseMessage.ParseEngine.MessageRecievedHandler(irc_MessageRecievedEvent);

			irc.ParseMessage(_client.GetStream() );

			Message( "** Connection Closed **" );
		}

		int maxWidth = 0;

		void AddUserName( string s )
		{
			if ( usersOnline.FindString( s ) < 0 )
			{
				Graphics g = Graphics.FromHwnd( this.Handle );

				SizeF w = g.MeasureString( String.Format(  "[{0}]", s ), richTextBox1.Font );

				g.Dispose();

				if ( (int) w.Width > maxWidth ) maxWidth = (int) w.Width ;

				usersOnline.Items.Add( s );
			}
		}

		void RemoveUserName( string s )
		{
			int index = usersOnline.FindString( s );

			if ( index >= 0 )
			{
				usersOnline.Items.RemoveAt( index );
			}
		}

		private void ChangeUserName( string oldName, string newName )
		{
			int index = usersOnline.FindString( oldName );

			if ( index >= 0 )
			{
				usersOnline.Items[ index ] = newName ;
			}
		}


		void irc_MessageRecievedEvent(object sender, ParseMessage.Message msg)
		{
			string reply = String.Empty;

			Debug( msg.ToString() );

			switch ( msg.Command.ToUpper() )
			{
				case "PRIVMSG":
					Message( String.Format( "[{0}]", msg.NickName ?? msg.ServerName ), msg.Params.Last<string>() );

					break;

				case "PING":
					reply = String.Format( "PONG {0}{1}{2}", msg.Params[ 0 ], msg.Params.Count > 1 && msg.Params[ 1 ].Length > 0 ? " " : "",
						msg.Params.Count > 1 && msg.Params[ 1 ].Length > 0 ? msg.Params[ 1 ] : "" );
					break;

				case "NOTICE" :
					Message( "** " + msg.Params.Last<string>() );
					break;

				case "001": case "002": case "003": case "004": case "251" : case "252" :
				case "253": case "254": case "255": case "266": case "375": case "372":
				case "MODE":  case "332": case "333": case "250" : case "265" :

					Message( msg.Params.Last<string>() );
					break;

				case "353":

					string[] names = msg.Params.Last<string>().Split( ' ' ) ;

					foreach ( string s in names )
					{
						this.Invoke( new MethodInvoker( delegate { AddUserName( s ); } ) );
					}
					break ;

				case "JOIN":

					Message( String.Format( "** {0} has joined {1}", msg.NickName, msg.Params.Last<string>() ) );
					this.Invoke( new MethodInvoker( delegate { AddUserName( msg.NickName ); } ) );
					break;

				case"005": case "366": case "376":
					break;

//Unhandled Command ->QUIT
//    Server -> 
// NickeName -> MrKotter
//      Host -> ool-4356245d.dyn.optonline.net
//      User -> ~MrKotter
//          -->Quit: MrKotter

				case "QUIT":
					Message( String.Format( "** {0} has quit", msg.NickName ) );
					this.Invoke( new MethodInvoker( delegate { RemoveUserName( msg.NickName ); } ) );
					break;

 //Unhandled Command ->NICK
 //   Server -> 
 //NickeName -> ptorre_
 //     Host -> xd8ad0a72.ip.e-nt.net
 //     User -> ~ptorre
 //         --> shoebootie

				case "NICK":
					Message( String.Format( "{0} is now {1}", msg.NickName, msg.Params.Last<string>() ) ) ;

					if ( this.InvokeRequired )
					{
						this.Invoke( new MethodInvoker( delegate { ChangeUserName( msg.NickName, msg.Params.Last<string>() ); } ) );
					}
					else
					{
						ChangeUserName( msg.NickName, msg.Params.Last<string>() ) ;
					}

					break ;

				default:

					Debug( "Unhandled Command ->" + msg.Command );

					Debug( "    Server -> " + msg.ServerName ) ;
					Debug( " NickeName -> " + msg.NickName ) ;
					Debug( "      Host -> " + msg.Host ) ;
					Debug( "      User -> " + msg.User );
                           
					foreach ( var s in msg.Params )
						Debug( "          --> " + s );
					break;
			}

			if ( reply.Length > 0 )
			{
				SendMsgToServer( reply );
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SendMsgToServer("QUIT");

			_client.Close();
		}

		public void DebugMsg( string msg )
		{
			// Debug( "DBG: " + msg );
		}

		public void Write( string msg )
		{
			Message( "RD:" + msg );
		}

		public void WriteLine( string msg )
		{
			Message( "RD:" + msg );
		}
	}
}
