namespace Helpdesk_Application
{
	partial class AddProduct
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
			this.txbx_productPrice = new System.Windows.Forms.TextBox();
			this.txbx_productName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_productQiymeti = new System.Windows.Forms.Label();
			this.btn_Add_product = new System.Windows.Forms.Button();
			this.productsTest = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txbx_productPrice
			// 
			this.txbx_productPrice.Location = new System.Drawing.Point(159, 90);
			this.txbx_productPrice.Name = "txbx_productPrice";
			this.txbx_productPrice.Size = new System.Drawing.Size(186, 20);
			this.txbx_productPrice.TabIndex = 0;
			// 
			// txbx_productName
			// 
			this.txbx_productName.Location = new System.Drawing.Point(159, 54);
			this.txbx_productName.Name = "txbx_productName";
			this.txbx_productName.Size = new System.Drawing.Size(186, 20);
			this.txbx_productName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Product adi:";
			// 
			// lbl_productQiymeti
			// 
			this.lbl_productQiymeti.AutoSize = true;
			this.lbl_productQiymeti.Location = new System.Drawing.Point(44, 97);
			this.lbl_productQiymeti.Name = "lbl_productQiymeti";
			this.lbl_productQiymeti.Size = new System.Drawing.Size(82, 13);
			this.lbl_productQiymeti.TabIndex = 3;
			this.lbl_productQiymeti.Text = "Product qiymeti:";
			// 
			// btn_Add_product
			// 
			this.btn_Add_product.Location = new System.Drawing.Point(374, 68);
			this.btn_Add_product.Name = "btn_Add_product";
			this.btn_Add_product.Size = new System.Drawing.Size(88, 31);
			this.btn_Add_product.TabIndex = 4;
			this.btn_Add_product.Text = "Add Product";
			this.btn_Add_product.UseVisualStyleBackColor = true;
			this.btn_Add_product.Click += new System.EventHandler(this.btn_Add_product_Click);
			// 
			// productsTest
			// 
			this.productsTest.AutoSize = true;
			this.productsTest.Location = new System.Drawing.Point(72, 158);
			this.productsTest.Name = "productsTest";
			this.productsTest.Size = new System.Drawing.Size(35, 13);
			this.productsTest.TabIndex = 5;
			this.productsTest.Text = "label2";
			// 
			// AddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 228);
			this.Controls.Add(this.productsTest);
			this.Controls.Add(this.btn_Add_product);
			this.Controls.Add(this.lbl_productQiymeti);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbx_productName);
			this.Controls.Add(this.txbx_productPrice);
			this.Name = "AddProduct";
			this.Text = "AddProduct";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbx_productPrice;
		private System.Windows.Forms.TextBox txbx_productName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_productQiymeti;
		private System.Windows.Forms.Button btn_Add_product;
		private System.Windows.Forms.Label productsTest;
	}
}