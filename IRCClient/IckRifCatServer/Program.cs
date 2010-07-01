﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IckRifCatServer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			MainForm = new ServerForm();
			Application.Run( MainForm );
		}

		public static ServerForm MainForm;
	}
}
