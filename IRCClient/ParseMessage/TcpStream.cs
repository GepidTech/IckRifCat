using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gt.ParserLibrary.Readers;
using System.Net.Sockets;

namespace ParseMessage
{
	public class TcpStream : Stream
	{
		System.IO.Stream r;

		int _CharacterIndex;
		int _LineNumber;
		byte[] _lookAhead;
		int _lookAheadIndex ;
		int _lookAheadLastIndex;
		bool _eof = false;

		public TcpStream(NetworkStream s, string source)
			: base(source)
		{
			r = s;
			_CharacterIndex = 0;
			_LineNumber = 1;
			_lookAhead = new byte[512];
			_lookAheadIndex = 0;
			_lookAheadLastIndex = 0;

			char ch ;

			ReadChar( out ch );

		}

		public override int CharacterIndex
		{
			get { return _CharacterIndex; }
		}


		public override bool ConsumeChar()
		{
			if (_eof)
			{
				m_currentChar = Stream.eofChar;
				return false;
			}

			if (_lookAheadIndex < _lookAheadLastIndex)
			{
				m_currentChar = (char)_lookAhead[_lookAheadIndex];
				Array.Copy(_lookAhead, _lookAheadIndex, _lookAhead, 0, _lookAheadLastIndex - _lookAheadIndex);
				_lookAheadLastIndex -= _lookAheadIndex;
				_lookAheadIndex = 0;
			}
			else
			{
				int b = - 1 ;
				try
				{
					b = r.ReadByte();
				}
				catch (System.IO.IOException ix)
				{
					SocketException sx = ix.InnerException as SocketException;

					// want to catch connection closed errors which is indicated by and end of file
					// by the stream.  This happens if the server closes the connection or any other
					// external event that would force the socket to close.
					if ( sx != null && sx.ErrorCode.In<int>( 10004, 10052, 10054 ) )
						b = -1;

					else
						throw ;
				}

				if (b == -1)
				{
					_eof = true;
					m_currentChar = Stream.eofChar;
					return false;
				}

				m_currentChar = (char)b;
			}

			if (m_currentChar == '\n')
			{
				_LineNumber++;
				_CharacterIndex = 1;
			}
			else
			{
				_CharacterIndex++;
			}

			return !_eof;
		}

		public override bool EOF
		{
			get { return _eof; }
		}

		public override int LineNumber
		{
			get { return _LineNumber; }
		}

		public override bool LookAhead(int howMany, out char laCh)
		{
			laCh = Stream.eofChar;

			if (howMany == 0)
			{
				if (_eof) return false;
				laCh = m_currentChar;
				return true;
			}

			howMany--;

			if (howMany >= _lookAheadLastIndex)
			{
				int read = (int)r.Read(_lookAhead, _lookAheadLastIndex, howMany + 1);

				_lookAheadLastIndex += read;

				if (read <= howMany)
				{
					return false;
				}
			}

			laCh = (char) _lookAhead[ howMany ] ;

			return true;

		}

		public override IStream OpenStream(object streamObject)
		{
			throw new NotImplementedException();
		}

		public override void SetStream(object streamObject)
		{
			throw new NotImplementedException();
		}
	}
}
