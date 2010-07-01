using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace IckRifCatServer
{
	public partial class ServerForm : Form
	{
		TcpListener _serverSocket;
		List<Client> _connectedClients = new List<Client>( 1000 );

		public ServerForm()
		{
			InitializeComponent();

			_serverSocket = new TcpListener( IPAddress.Loopback, 6665 );
			_serverSocket.Start();
			_serverSocket.BeginAcceptTcpClient( new AsyncCallback( AcceptNewClient ), null );

			DebugMessage( "Ready." );
		}

		private void _PrintMessage( string msg )
		{
			_messages.SelectionStart = _messages.TextLength;
			_messages.SelectionLength = 0;
			_messages.SelectedText = msg + "\r\n";
		}

		private void _PrintDebugMessage( string msg )
		{
			_debug.SelectionStart = _debug.TextLength;
			_debug.SelectionLength = 0;
			_debug.SelectedText = msg + "\r\n";
		}

		public void Message( string msg )
		{
			if ( InvokeRequired )
			{
				this.Invoke( new MethodInvoker( delegate { _PrintMessage( msg ); } ) );
			}
			else
			{
				_PrintMessage( msg );
			}
		}

		public void DebugMessage( string msg )
		{
			if ( InvokeRequired )
			{
				this.Invoke( new MethodInvoker( delegate { _PrintDebugMessage( msg ); } ) );
			}
			else
			{
				_PrintDebugMessage( msg );
			}
		}

		void AcceptNewClient( IAsyncResult r )
		{
			TcpClient clientConnection = _serverSocket.EndAcceptTcpClient( r );

			DebugMessage( "Client Connection Request Accepted" );
			Client c = new Client( clientConnection );

			_connectedClients.Add( c );

			_serverSocket.BeginAcceptTcpClient( new AsyncCallback( AcceptNewClient ), null );
		}

		public void SendQuitToChannel( Client c )
		{
		}

		public void RemoveClient( Client c )
		{
			_connectedClients.Remove( c );
		}
	}
}
