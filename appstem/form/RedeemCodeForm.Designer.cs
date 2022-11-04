namespace appstem.form
{
	partial class RedeemCodeForm
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
			this.dataRedeemGrid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.codeRedeemGrib = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.nameRedeemTB = new System.Windows.Forms.TextBox();
			this.gameidRedeemTB = new System.Windows.Forms.TextBox();
			this.addRedeemTB = new System.Windows.Forms.Button();
			this.editRedeemTB = new System.Windows.Forms.Button();
			this.removeRedeemTB = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataRedeemGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.codeRedeemGrib)).BeginInit();
			this.SuspendLayout();
			// 
			// dataRedeemGrid
			// 
			this.dataRedeemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataRedeemGrid.Location = new System.Drawing.Point(22, 29);
			this.dataRedeemGrid.Name = "dataRedeemGrid";
			this.dataRedeemGrid.Size = new System.Drawing.Size(461, 398);
			this.dataRedeemGrid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(520, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Redeem ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(523, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Game:";
			// 
			// codeRedeemGrib
			// 
			this.codeRedeemGrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.codeRedeemGrib.Location = new System.Drawing.Point(526, 118);
			this.codeRedeemGrib.Name = "codeRedeemGrib";
			this.codeRedeemGrib.Size = new System.Drawing.Size(240, 150);
			this.codeRedeemGrib.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(526, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Code:";
			// 
			// nameRedeemTB
			// 
			this.nameRedeemTB.Location = new System.Drawing.Point(591, 29);
			this.nameRedeemTB.Name = "nameRedeemTB";
			this.nameRedeemTB.Size = new System.Drawing.Size(175, 20);
			this.nameRedeemTB.TabIndex = 5;
			// 
			// gameidRedeemTB
			// 
			this.gameidRedeemTB.Location = new System.Drawing.Point(591, 57);
			this.gameidRedeemTB.Name = "gameidRedeemTB";
			this.gameidRedeemTB.Size = new System.Drawing.Size(175, 20);
			this.gameidRedeemTB.TabIndex = 6;
			// 
			// addRedeemTB
			// 
			this.addRedeemTB.Location = new System.Drawing.Point(526, 294);
			this.addRedeemTB.Name = "addRedeemTB";
			this.addRedeemTB.Size = new System.Drawing.Size(113, 32);
			this.addRedeemTB.TabIndex = 7;
			this.addRedeemTB.Text = "Add";
			this.addRedeemTB.UseVisualStyleBackColor = true;
			// 
			// editRedeemTB
			// 
			this.editRedeemTB.Location = new System.Drawing.Point(667, 294);
			this.editRedeemTB.Name = "editRedeemTB";
			this.editRedeemTB.Size = new System.Drawing.Size(99, 32);
			this.editRedeemTB.TabIndex = 8;
			this.editRedeemTB.Text = "Edit";
			this.editRedeemTB.UseVisualStyleBackColor = true;
			// 
			// removeRedeemTB
			// 
			this.removeRedeemTB.Location = new System.Drawing.Point(526, 343);
			this.removeRedeemTB.Name = "removeRedeemTB";
			this.removeRedeemTB.Size = new System.Drawing.Size(240, 38);
			this.removeRedeemTB.TabIndex = 9;
			this.removeRedeemTB.Text = "Remove";
			this.removeRedeemTB.UseVisualStyleBackColor = true;
			// 
			// RedeemCodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.removeRedeemTB);
			this.Controls.Add(this.editRedeemTB);
			this.Controls.Add(this.addRedeemTB);
			this.Controls.Add(this.gameidRedeemTB);
			this.Controls.Add(this.nameRedeemTB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.codeRedeemGrib);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataRedeemGrid);
			this.Name = "RedeemCodeForm";
			this.Text = "RedeemCodeForm";
			((System.ComponentModel.ISupportInitialize)(this.dataRedeemGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.codeRedeemGrib)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataRedeemGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView codeRedeemGrib;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameRedeemTB;
		private System.Windows.Forms.TextBox gameidRedeemTB;
		private System.Windows.Forms.Button addRedeemTB;
		private System.Windows.Forms.Button editRedeemTB;
		private System.Windows.Forms.Button removeRedeemTB;
	}
}