namespace IckRifCatServer
{
	partial class ServerForm
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
			this._messages = new System.Windows.Forms.RichTextBox();
			this._debug = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _messages
			// 
			this._messages.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this._messages.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this._messages.Location = new System.Drawing.Point( 12, 12 );
			this._messages.Name = "_messages";
			this._messages.Size = new System.Drawing.Size( 581, 280 );
			this._messages.TabIndex = 0;
			this._messages.Text = "";
			// 
			// _debug
			// 
			this._debug.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this._debug.Font = new System.Drawing.Font( "Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this._debug.Location = new System.Drawing.Point( 13, 299 );
			this._debug.Name = "_debug";
			this._debug.Size = new System.Drawing.Size( 580, 96 );
			this._debug.TabIndex = 1;
			this._debug.Text = "";
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 605, 406 );
			this.Controls.Add( this._debug );
			this.Controls.Add( this._messages );
			this.Name = "ServerForm";
			this.Text = "Form1";
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.RichTextBox _messages;
		private System.Windows.Forms.RichTextBox _debug;
	}
}

