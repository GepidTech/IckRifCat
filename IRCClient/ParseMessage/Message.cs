using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

		public override string ToString()
		{
			StringWriter sw = new StringWriter( new StringBuilder( 1000 ) );

			sw.WriteLine( "   Command -> {0}", this.Command );
			sw.WriteLine( "    Server -> {0}", this.ServerName );
			sw.WriteLine( "  NickName -> {0}", this.NickName );
			sw.WriteLine( "      Host -> {0}", this.Host );
			sw.WriteLine( "      User -> {0}", this.User );

			int parNo = 1;
			foreach ( var s in this.Params )
			{
				sw.WriteLine( "     [{0,2}] --> {1}", parNo ++, s );
			}


			return sw.ToString();
		}
	}
}
