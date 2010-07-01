using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ickRifCat
{
	public partial class UserInfo : Form
	{
		public UserInfo()
		{
			InitializeComponent();
		}

		public string UserName { get { return userName.Text; } set { userName.Text = value; } }
		public string Password { get { return password.Text; } set { password.Text = value; } }
		public string NickName { get { return nickName.Text; } set { nickName.Text = value; } }
	}
}
