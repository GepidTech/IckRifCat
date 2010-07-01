namespace ickRifCat
{
	partial class ServerConnection
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
			this.serverName = new System.Windows.Forms.TextBox();
			this.portNumber = new System.Windows.Forms.TextBox();
			this.cmdConnect = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point( 31, 28 );
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size( 38, 13 );
			label1.TabIndex = 0;
			label1.Text = "Server";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point( 31, 54 );
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size( 26, 13 );
			label2.TabIndex = 1;
			label2.Text = "Port";
			// 
			// serverName
			// 
			this.serverName.Cursor = System.Windows.Forms.Cursors.UpArrow;
			this.serverName.Location = new System.Drawing.Point( 75, 25 );
			this.serverName.Name = "serverName";
			this.serverName.Size = new System.Drawing.Size( 236, 20 );
			this.serverName.TabIndex = 2;
			this.serverName.Text = "verne.freenode.net";
			// 
			// portNumber
			// 
			this.portNumber.Location = new System.Drawing.Point( 75, 51 );
			this.portNumber.Name = "portNumber";
			this.portNumber.Size = new System.Drawing.Size( 80, 20 );
			this.portNumber.TabIndex = 3;
			this.portNumber.Text = "6665";
			// 
			// cmdConnect
			// 
			this.cmdConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdConnect.Location = new System.Drawing.Point( 146, 92 );
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size( 75, 23 );
			this.cmdConnect.TabIndex = 4;
			this.cmdConnect.Text = "Connect";
			this.cmdConnect.UseVisualStyleBackColor = true;
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point( 236, 92 );
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size( 75, 23 );
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			// 
			// ServerConnection
			// 
			this.AcceptButton = this.cmdConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size( 319, 130 );
			this.Controls.Add( this.cmdCancel );
			this.Controls.Add( this.cmdConnect );
			this.Controls.Add( this.portNumber );
			this.Controls.Add( this.serverName );
			this.Controls.Add( label2 );
			this.Controls.Add( label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ServerConnection";
			this.Text = "ServerConnection";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox serverName;
		private System.Windows.Forms.TextBox portNumber;
		private System.Windows.Forms.Button cmdConnect;
		private System.Windows.Forms.Button cmdCancel;
	}
}