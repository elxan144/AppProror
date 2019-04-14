namespace Helpdesk_Application
{
	partial class AdminForm
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
			this.linkLabel_CardGenearte = new System.Windows.Forms.LinkLabel();
			this.link_lbl_xidmetForm = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// linkLabel_CardGenearte
			// 
			this.linkLabel_CardGenearte.AutoSize = true;
			this.linkLabel_CardGenearte.Location = new System.Drawing.Point(13, 35);
			this.linkLabel_CardGenearte.Name = "linkLabel_CardGenearte";
			this.linkLabel_CardGenearte.Size = new System.Drawing.Size(75, 13);
			this.linkLabel_CardGenearte.TabIndex = 0;
			this.linkLabel_CardGenearte.TabStop = true;
			this.linkLabel_CardGenearte.Text = "Card elave ele";
			this.linkLabel_CardGenearte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CardGenearte_LinkClicked);
			// 
			// link_lbl_xidmetForm
			// 
			this.link_lbl_xidmetForm.AutoSize = true;
			this.link_lbl_xidmetForm.Location = new System.Drawing.Point(16, 79);
			this.link_lbl_xidmetForm.Name = "link_lbl_xidmetForm";
			this.link_lbl_xidmetForm.Size = new System.Drawing.Size(80, 13);
			this.link_lbl_xidmetForm.TabIndex = 1;
			this.link_lbl_xidmetForm.TabStop = true;
			this.link_lbl_xidmetForm.Text = "Xidmet elave et";
			this.link_lbl_xidmetForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_xidmetForm_LinkClicked);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 261);
			this.Controls.Add(this.link_lbl_xidmetForm);
			this.Controls.Add(this.linkLabel_CardGenearte);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel_CardGenearte;
		private System.Windows.Forms.LinkLabel link_lbl_xidmetForm;
	}
}