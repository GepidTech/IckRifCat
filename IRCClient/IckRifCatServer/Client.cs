﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using ParseMessage.ParseEngine;
using Gt.ParserLibrary.Readers;

namespace IckRifCatServer
{
	public class Client
	{
		enum States : int
		{
			Initial = 0
		,	Server = 1
		,	Password = 2
		,	UserName = 3
		,	Nickname = 4
		,	Active = 5
		,	Quit = 6
		} ;

		TcpClient _clientSocket;

		byte[]    _buffer = new byte[ 512 ];

		States _state = States.Initial ;

		IrcMsgParser _parser;
		StringStream _input;

		string userName;
		string password;
		string nickName;
		string server;

		string currentChannel;
		string newChannel;

		string leftOver = "";

		public void SendClientMessage( string msg )
		{
			byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes( msg );

			_input = new StringStream( "", "IP" );
			_parser = new IrcMsgParser( _input );

			_parser.MessageRecievedEvent += new MessageRecievedHandler( _parser_MessageRecievedEvent );
			_clientSocket.Client.Send( bytes );
		}

		void InitialState( ParseMessage.Message msg )
		{
			if ( String.Compare( msg.Command, "PASS", true ) != 0 )
			{
			}
		}

		void _parser_MessageRecievedEvent( object sender, ParseMessage.Message msg )
		{
			switch ( _state )
			{
				case States.Initial:
					InitialState( msg );
					break;

			}

			switch ( msg.Command.ToUpper() )
			{
				case "PASS":
					password = msg.Params.Last<string>();
					break;

				case "USER":
					userName = msg.Params.Last<string>();
					break;

				case "NICK":
					nickName = msg.Params.Last<string>();
					break;

				case "JOIN":
					newChannel = msg.Params.Last<string>();
					break;

				default:
					break;
			}

			Program.MainForm.DebugMessage( String.Format( "ClientMessage -> {0}", msg.Command ) );
		}

		public Client( TcpClient connection )
		{
			_clientSocket = connection;
			_state = States.Initial;
			SendClientMessage ( "NOTICE * :Hello\r\n" ) ;
			IPEndPoint soc = _clientSocket.Client.RemoteEndPoint as IPEndPoint ;

			IPHostEntry e = System.Net.Dns.GetHostEntry( soc.Address ); ;

			if ( e == null )
			{
				SendClientMessage( "NOTICE * :Can't Resolve Name\r\n" );
				server = soc.Address.ToString();
			}
			else
			{
				SendClientMessage( String.Format( "NOTICE * :Connected from {0}\r\n", e.HostName ) );
				server = e.HostName;
			}


			Program.MainForm.DebugMessage( "Client connected." );

			_clientSocket.Client.BeginReceive( _buffer, 0, _buffer.Length, SocketFlags.None, DataRead, null );
		}

		void DataRead( IAsyncResult r )
		{
			SocketError ec;

			int length = _clientSocket.Client.EndReceive( r, out ec );

			if ( length == 0 )
			{
				_clientSocket.Close();
				Program.MainForm.SendQuitToChannel( this );
				Program.MainForm.RemoveClient( this );
			}
			else
			{
				String input = leftOver + System.Text.ASCIIEncoding.ASCII.GetString( _buffer, 0, length ) ;

				leftOver = String.Empty;

				int lfIndex = input.IndexOf( "\n" );
				while ( lfIndex >= 0 )
				{
					leftOver = input.Substring( lfIndex + 1 );

					input = input.Substring( 0, lfIndex + 1 );

					_input.SetStream( input );
					_input.ResetStream();
					_parser.Parse();

					input = leftOver;
					lfIndex = input.IndexOf( "\n" );
				}

				leftOver = input;

				_clientSocket.Client.BeginReceive( _buffer, 0, _buffer.Length, SocketFlags.None, DataRead, null );
			}
		}
	}
}
