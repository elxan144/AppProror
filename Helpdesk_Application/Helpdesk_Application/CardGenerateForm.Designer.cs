namespace Helpdesk_Application
{
	partial class CardGenerateForm
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
			this.lbl_generatedCard = new System.Windows.Forms.Label();
			this.lbl_generatedCardPrice = new System.Windows.Forms.Label();
			this.btn_cardGenerate = new System.Windows.Forms.Button();
			this.btn_AddCard = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_generatedCard
			// 
			this.lbl_generatedCard.AutoSize = true;
			this.lbl_generatedCard.Location = new System.Drawing.Point(52, 31);
			this.lbl_generatedCard.Name = "lbl_generatedCard";
			this.lbl_generatedCard.Size = new System.Drawing.Size(35, 13);
			this.lbl_generatedCard.TabIndex = 0;
			this.lbl_generatedCard.Text = "label1";
			// 
			// lbl_generatedCardPrice
			// 
			this.lbl_generatedCardPrice.AutoSize = true;
			this.lbl_generatedCardPrice.Location = new System.Drawing.Point(55, 68);
			this.lbl_generatedCardPrice.Name = "lbl_generatedCardPrice";
			this.lbl_generatedCardPrice.Size = new System.Drawing.Size(35, 13);
			this.lbl_generatedCardPrice.TabIndex = 1;
			this.lbl_generatedCardPrice.Text = "label2";
			// 
			// btn_cardGenerate
			// 
			this.btn_cardGenerate.Location = new System.Drawing.Point(207, 43);
			this.btn_cardGenerate.Name = "btn_cardGenerate";
			this.btn_cardGenerate.Size = new System.Drawing.Size(75, 23);
			this.btn_cardGenerate.TabIndex = 2;
			this.btn_cardGenerate.Text = "Generate";
			this.btn_cardGenerate.UseVisualStyleBackColor = true;
			this.btn_cardGenerate.Click += new System.EventHandler(this.btn_cardGenerate_Click);
			// 
			// btn_AddCard
			// 
			this.btn_AddCard.Location = new System.Drawing.Point(128, 126);
			this.btn_AddCard.Name = "btn_AddCard";
			this.btn_AddCard.Size = new System.Drawing.Size(75, 23);
			this.btn_AddCard.TabIndex = 3;
			this.btn_AddCard.Text = "Add Card";
			this.btn_AddCard.UseVisualStyleBackColor = true;
			this.btn_AddCard.Click += new System.EventHandler(this.btn_AddCard_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// CardGenerateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 199);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_AddCard);
			this.Controls.Add(this.btn_cardGenerate);
			this.Controls.Add(this.lbl_generatedCardPrice);
			this.Controls.Add(this.lbl_generatedCard);
			this.Name = "CardGenerateForm";
			this.Text = "CardGenerateForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_generatedCard;
		private System.Windows.Forms.Label lbl_generatedCardPrice;
		private System.Windows.Forms.Button btn_cardGenerate;
		private System.Windows.Forms.Button btn_AddCard;
		private System.Windows.Forms.Label label1;
	}
}