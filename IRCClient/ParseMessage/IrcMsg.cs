using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gt.ParserLibrary.Writers;
using Gt.ParserLibrary.Readers;
using ParseMessage.ParseEngine;
using System.Net.Sockets;

namespace ParseMessage
{
	public class IrcMsg
	{
		public event MessageRecievedHandler MessageRecievedEvent ;

		public IWriter Output { get; set; }

		protected void FireMessageRecieved( Message msg)
		{
			if ( MessageRecievedEvent != null )
				MessageRecievedEvent( this, msg ) ;
		}

		public void ParseMessage(NetworkStream s)
		{
			IStream gFileIn = new TcpStream(s, "TcpStream");

			IrcMsgContext msg = new IrcMsgParser(gFileIn);

			msg.StdOut = Output;

			msg.MessageRecievedEvent += new MessageRecievedHandler( (o, m) => FireMessageRecieved( m ) ) ; // /*msg_MessageRecievedEvent*/);
			if (msg.Parse())
			{
			}
		}

		void msg_MessageRecievedEvent(object sender, Message msg)
		{
			FireMessageRecieved(msg);
		}

	}
}
