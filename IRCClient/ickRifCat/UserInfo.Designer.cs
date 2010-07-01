namespace ickRifCat
{
	partial class UserInfo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
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
			this.userName = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.nickName = new System.Windows.Forms.TextBox();
			this.cmdOk = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point( 12, 9 );
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size( 60, 13 );
			label1.TabIndex = 0;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point( 12, 37 );
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size( 53, 13 );
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point( 12, 63 );
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size( 60, 13 );
			label3.TabIndex = 2;
			label3.Text = "Nick Name";
			// 
			// userName
			// 
			this.userName.Location = new System.Drawing.Point( 78, 6 );
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size( 100, 20 );
			this.userName.TabIndex = 3;
			this.userName.Text = "scbirk1";
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point( 78, 34 );
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size( 100, 20 );
			this.password.TabIndex = 4;
			this.password.Text = "nopassword";
			// 
			// nickName
			// 
			this.nickName.Location = new System.Drawing.Point( 78, 60 );
			this.nickName.Name = "nickName";
			this.nickName.Size = new System.Drawing.Size( 100, 20 );
			this.nickName.TabIndex = 5;
			this.nickName.Text = "Gunter";
			// 
			// cmdOk
			// 
			this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOk.Location = new System.Drawing.Point( 103, 101 );
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size( 75, 23 );
			this.cmdOk.TabIndex = 6;
			this.cmdOk.Text = "OK";
			this.cmdOk.UseVisualStyleBackColor = true;
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point( 103, 130 );
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size( 75, 23 );
			this.cmdCancel.TabIndex = 7;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			// 
			// UserInfo
			// 
			this.AcceptButton = this.cmdOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size( 184, 163 );
			this.Controls.Add( this.cmdCancel );
			this.Controls.Add( this.cmdOk );
			this.Controls.Add( this.nickName );
			this.Controls.Add( this.password );
			this.Controls.Add( this.userName );
			this.Controls.Add( label3 );
			this.Controls.Add( label2 );
			this.Controls.Add( label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserInfo";
			this.Text = "User Info";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox nickName;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.Button cmdCancel;
	}
}