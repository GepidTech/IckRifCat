using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gt.ParserLibrary;
using Gt.ParserLibrary.Readers;
using Gt.ParserLibrary.Tokens;
using Gt.ParserLibrary.Parser;

namespace ParseMessage.ParseEngine
{
	public delegate void MessageRecievedHandler(object sender, Message msg);

	public abstract class IrcMsgContext : BaseParser
	{
		protected List<Message> _messages = new List<Message>();
		protected Message _currentMessage;

		public event MessageRecievedHandler MessageRecievedEvent;

		protected void FireMessageRecieved()
		{
			if (MessageRecievedEvent != null)
				MessageRecievedEvent(this, _currentMessage);
		}

		public IrcMsgContext(IStream i)
			: base( i )
		{
			
		}

	}
}
