namespace appstem
{
	partial class DisEvent
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
			this.label4 = new System.Windows.Forms.Label();
			this.idDisEventTB = new System.Windows.Forms.TextBox();
			this.addDisEventBTN = new System.Windows.Forms.Button();
			this.editDisEventBTN = new System.Windows.Forms.Button();
			this.removeDisEventBTN = new System.Windows.Forms.Button();
			this.amountDisEventTB = new System.Windows.Forms.TextBox();
			this.typeDisEventTB = new System.Windows.Forms.TextBox();
			this.nameDisEventTB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridDisEV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridDisEV)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 298);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "ID Discount want to remove:";
			// 
			// idDisEventTB
			// 
			this.idDisEventTB.Location = new System.Drawing.Point(177, 298);
			this.idDisEventTB.Name = "idDisEventTB";
			this.idDisEventTB.Size = new System.Drawing.Size(130, 20);
			this.idDisEventTB.TabIndex = 23;
			// 
			// addDisEventBTN
			// 
			this.addDisEventBTN.Location = new System.Drawing.Point(29, 181);
			this.addDisEventBTN.Name = "addDisEventBTN";
			this.addDisEventBTN.Size = new System.Drawing.Size(109, 44);
			this.addDisEventBTN.TabIndex = 22;
			this.addDisEventBTN.Text = "Add DisEvent";
			this.addDisEventBTN.UseVisualStyleBackColor = true;
			this.addDisEventBTN.Click += new System.EventHandler(this.addDisEventBTN_Click);
			// 
			// editDisEventBTN
			// 
			this.editDisEventBTN.Location = new System.Drawing.Point(183, 181);
			this.editDisEventBTN.Name = "editDisEventBTN";
			this.editDisEventBTN.Size = new System.Drawing.Size(124, 38);
			this.editDisEventBTN.TabIndex = 21;
			this.editDisEventBTN.Text = "Edit";
			this.editDisEventBTN.UseVisualStyleBackColor = true;
			this.editDisEventBTN.Click += new System.EventHandler(this.editDisEventBTN_Click);
			// 
			// removeDisEventBTN
			// 
			this.removeDisEventBTN.Location = new System.Drawing.Point(29, 335);
			this.removeDisEventBTN.Name = "removeDisEventBTN";
			this.removeDisEventBTN.Size = new System.Drawing.Size(278, 38);
			this.removeDisEventBTN.TabIndex = 20;
			this.removeDisEventBTN.Text = "Remove";
			this.removeDisEventBTN.UseVisualStyleBackColor = true;
			this.removeDisEventBTN.Click += new System.EventHandler(this.removeDisEventBTN_Click);
			// 
			// amountDisEventTB
			// 
			this.amountDisEventTB.Location = new System.Drawing.Point(183, 143);
			this.amountDisEventTB.Name = "amountDisEventTB";
			this.amountDisEventTB.Size = new System.Drawing.Size(124, 20);
			this.amountDisEventTB.TabIndex = 19;
			// 
			// typeDisEventTB
			// 
			this.typeDisEventTB.Location = new System.Drawing.Point(29, 143);
			this.typeDisEventTB.Name = "typeDisEventTB";
			this.typeDisEventTB.Size = new System.Drawing.Size(109, 20);
			this.typeDisEventTB.TabIndex = 18;
			// 
			// nameDisEventTB
			// 
			this.nameDisEventTB.Location = new System.Drawing.Point(29, 78);
			this.nameDisEventTB.Name = "nameDisEventTB";
			this.nameDisEventTB.Size = new System.Drawing.Size(278, 20);
			this.nameDisEventTB.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(180, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Amount";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Name";
			// 
			// gridDisEV
			// 
			this.gridDisEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDisEV.Location = new System.Drawing.Point(358, 37);
			this.gridDisEV.Name = "gridDisEV";
			this.gridDisEV.Size = new System.Drawing.Size(469, 483);
			this.gridDisEV.TabIndex = 13;
			// 
			// DisEvent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 546);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.idDisEventTB);
			this.Controls.Add(this.addDisEventBTN);
			this.Controls.Add(this.editDisEventBTN);
			this.Controls.Add(this.removeDisEventBTN);
			this.Controls.Add(this.amountDisEventTB);
			this.Controls.Add(this.typeDisEventTB);
			this.Controls.Add(this.nameDisEventTB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridDisEV);
			this.Name = "DisEvent";
			this.Text = "DisEventForm";
			((System.ComponentModel.ISupportInitialize)(this.gridDisEV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox idDisEventTB;
		private System.Windows.Forms.Button addDisEventBTN;
		private System.Windows.Forms.Button editDisEventBTN;
		private System.Windows.Forms.Button removeDisEventBTN;
		private System.Windows.Forms.TextBox amountDisEventTB;
		private System.Windows.Forms.TextBox typeDisEventTB;
		private System.Windows.Forms.TextBox nameDisEventTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridDisEV;
	}
}

