namespace ickRifCat
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label7;
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._channelName = new System.Windows.Forms.TextBox();
			this._nickname = new System.Windows.Forms.TextBox();
			this._password = new System.Windows.Forms.TextBox();
			this._userName = new System.Windows.Forms.TextBox();
			this._port = new System.Windows.Forms.TextBox();
			this._serverName = new System.Windows.Forms.TextBox();
			this.usersOnline = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.msgReader = new System.ComponentModel.BackgroundWorker();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this._debug = new System.Windows.Forms.RichTextBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point( 7, 127 );
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size( 38, 13 );
			label1.TabIndex = 3;
			label1.Text = "Server";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point( 8, 168 );
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size( 26, 13 );
			label2.TabIndex = 5;
			label2.Text = "Port";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point( 8, 211 );
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size( 60, 13 );
			label3.TabIndex = 7;
			label3.Text = "User Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point( 8, 254 );
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size( 53, 13 );
			label4.TabIndex = 9;
			label4.Text = "Password";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point( 8, 297 );
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size( 55, 13 );
			label5.TabIndex = 10;
			label5.Text = "Nickname";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point( 8, 340 );
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size( 46, 13 );
			label6.TabIndex = 11;
			label6.Text = "Channel";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point( 11, 8 );
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size( 37, 13 );
			label7.TabIndex = 15;
			label7.Text = "Online";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.splitContainer1.Location = new System.Drawing.Point( 3, 3 );
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add( label7 );
			this.splitContainer1.Panel1.Controls.Add( this._channelName );
			this.splitContainer1.Panel1.Controls.Add( this._nickname );
			this.splitContainer1.Panel1.Controls.Add( this._password );
			this.splitContainer1.Panel1.Controls.Add( label6 );
			this.splitContainer1.Panel1.Controls.Add( label5 );
			this.splitContainer1.Panel1.Controls.Add( label4 );
			this.splitContainer1.Panel1.Controls.Add( this._userName );
			this.splitContainer1.Panel1.Controls.Add( label3 );
			this.splitContainer1.Panel1.Controls.Add( this._port );
			this.splitContainer1.Panel1.Controls.Add( label2 );
			this.splitContainer1.Panel1.Controls.Add( this._serverName );
			this.splitContainer1.Panel1.Controls.Add( label1 );
			this.splitContainer1.Panel1.Controls.Add( this.usersOnline );
			this.splitContainer1.Panel1.Controls.Add( this.button1 );
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add( this.textBox1 );
			this.splitContainer1.Panel2.Controls.Add( this.richTextBox1 );
			this.splitContainer1.Size = new System.Drawing.Size( 751, 420 );
			this.splitContainer1.SplitterDistance = 130;
			this.splitContainer1.TabIndex = 0;
			// 
			// _channelName
			// 
			this._channelName.Location = new System.Drawing.Point( 8, 358 );
			this._channelName.Name = "_channelName";
			this._channelName.Size = new System.Drawing.Size( 100, 20 );
			this._channelName.TabIndex = 14;
			// 
			// _nickname
			// 
			this._nickname.Location = new System.Drawing.Point( 8, 315 );
			this._nickname.Name = "_nickname";
			this._nickname.Size = new System.Drawing.Size( 100, 20 );
			this._nickname.TabIndex = 13;
			// 
			// _password
			// 
			this._password.Location = new System.Drawing.Point( 8, 272 );
			this._password.Name = "_password";
			this._password.PasswordChar = '*';
			this._password.Size = new System.Drawing.Size( 100, 20 );
			this._password.TabIndex = 12;
			// 
			// _userName
			// 
			this._userName.Location = new System.Drawing.Point( 8, 229 );
			this._userName.Name = "_userName";
			this._userName.Size = new System.Drawing.Size( 100, 20 );
			this._userName.TabIndex = 8;
			// 
			// _port
			// 
			this._port.Location = new System.Drawing.Point( 8, 186 );
			this._port.Name = "_port";
			this._port.Size = new System.Drawing.Size( 100, 20 );
			this._port.TabIndex = 6;
			// 
			// _serverName
			// 
			this._serverName.Location = new System.Drawing.Point( 8, 143 );
			this._serverName.Name = "_serverName";
			this._serverName.Size = new System.Drawing.Size( 100, 20 );
			this._serverName.TabIndex = 4;
			this._serverName.Text = "verne.freenode.net";
			// 
			// usersOnline
			// 
			this.usersOnline.FormattingEnabled = true;
			this.usersOnline.Location = new System.Drawing.Point( 7, 29 );
			this.usersOnline.Name = "usersOnline";
			this.usersOnline.Size = new System.Drawing.Size( 120, 95 );
			this.usersOnline.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.button1.Location = new System.Drawing.Point( 17, 384 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size( 97, 23 );
			this.button1.TabIndex = 1;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler( this.button1_Click );
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.textBox1.Location = new System.Drawing.Point( 3, 397 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size( 608, 20 );
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox1_KeyPress );
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.richTextBox1.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.richTextBox1.Location = new System.Drawing.Point( 3, 7 );
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size( 608, 384 );
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// msgReader
			// 
			this.msgReader.DoWork += new System.ComponentModel.DoWorkEventHandler( this.msgReader_DoWork );
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.splitContainer2.Location = new System.Drawing.Point( 2, 2 );
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add( this.splitContainer1 );
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add( this._debug );
			this.splitContainer2.Size = new System.Drawing.Size( 757, 524 );
			this.splitContainer2.SplitterDistance = 426;
			this.splitContainer2.TabIndex = 1;
			// 
			// _debug
			// 
			this._debug.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this._debug.Font = new System.Drawing.Font( "Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this._debug.Location = new System.Drawing.Point( 3, 3 );
			this._debug.Name = "_debug";
			this._debug.ReadOnly = true;
			this._debug.Size = new System.Drawing.Size( 751, 88 );
			this._debug.TabIndex = 0;
			this._debug.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 762, 529 );
			this.Controls.Add( this.splitContainer2 );
			this.Name = "Form1";
			this.Text = "IRC Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.Form1_FormClosing );
			this.splitContainer1.Panel1.ResumeLayout( false );
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout( false );
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout( false );
			this.splitContainer2.Panel1.ResumeLayout( false );
			this.splitContainer2.Panel2.ResumeLayout( false );
			this.splitContainer2.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.BackgroundWorker msgReader;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox _debug;
		private System.Windows.Forms.ListBox usersOnline;
		private System.Windows.Forms.TextBox _channelName;
		private System.Windows.Forms.TextBox _nickname;
		private System.Windows.Forms.TextBox _password;
		private System.Windows.Forms.TextBox _userName;
		private System.Windows.Forms.TextBox _port;
		private System.Windows.Forms.TextBox _serverName;
	}
}

