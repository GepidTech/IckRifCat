using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseMessage
{
	public class Message
	{

		protected List<String> _params = new List<string>() ;

		public String ServerName { get; internal set; }
		public String NickName { get; internal set; }
		public String User { get; internal set; }
		public String Host { get; internal set; }

		public List<String> Params { get { return _params; } }

		public String Command { get; internal set; }
	}
}
