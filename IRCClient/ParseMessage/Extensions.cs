using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseMessage
{
	public static class Extensions
	{
		public static bool In<T>( this T what, params T[] items )
		{
			return items.Contains<T>( what );
		}
	}
}
