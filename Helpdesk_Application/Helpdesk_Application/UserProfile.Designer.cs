namespace Helpdesk_Application
{
	partial class UserProfile
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
			this.lbl_balansUser = new System.Windows.Forms.Label();
			this.comboBox_Products = new System.Windows.Forms.ComboBox();
			this.btn_buy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_balansUser
			// 
			this.lbl_balansUser.AutoSize = true;
			this.lbl_balansUser.Location = new System.Drawing.Point(444, 13);
			this.lbl_balansUser.Name = "lbl_balansUser";
			this.lbl_balansUser.Size = new System.Drawing.Size(51, 13);
			this.lbl_balansUser.TabIndex = 0;
			this.lbl_balansUser.Text = "Balans: 0";
			// 
			// comboBox_Products
			// 
			this.comboBox_Products.FormattingEnabled = true;
			this.comboBox_Products.Location = new System.Drawing.Point(116, 77);
			this.comboBox_Products.Name = "comboBox_Products";
			this.comboBox_Products.Size = new System.Drawing.Size(216, 21);
			this.comboBox_Products.TabIndex = 1;
			this.comboBox_Products.SelectedIndexChanged += new System.EventHandler(this.comboBox_Products_SelectedIndexChanged);
			// 
			// btn_buy
			// 
			this.btn_buy.Location = new System.Drawing.Point(178, 143);
			this.btn_buy.Name = "btn_buy";
			this.btn_buy.Size = new System.Drawing.Size(75, 23);
			this.btn_buy.TabIndex = 2;
			this.btn_buy.Text = "BUY";
			this.btn_buy.UseVisualStyleBackColor = true;
			// 
			// UserProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 261);
			this.Controls.Add(this.btn_buy);
			this.Controls.Add(this.comboBox_Products);
			this.Controls.Add(this.lbl_balansUser);
			this.Name = "UserProfile";
			this.Text = "UserProfile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_balansUser;
		private System.Windows.Forms.ComboBox comboBox_Products;
		private System.Windows.Forms.Button btn_buy;
	}
}