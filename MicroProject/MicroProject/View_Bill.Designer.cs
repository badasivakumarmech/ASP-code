
namespace MicroProject
{
    partial class View_Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectBill = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Bill Number";
            // 
            // cmbSelectBill
            // 
            this.cmbSelectBill.FormattingEnabled = true;
            this.cmbSelectBill.Location = new System.Drawing.Point(374, 18);
            this.cmbSelectBill.Name = "cmbSelectBill";
            this.cmbSelectBill.Size = new System.Drawing.Size(237, 37);
            this.cmbSelectBill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Details";
            // 
            // DGVBill
            // 
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.Location = new System.Drawing.Point(17, 95);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.RowHeadersWidth = 62;
            this.DGVBill.RowTemplate.Height = 28;
            this.DGVBill.Size = new System.Drawing.Size(844, 150);
            this.DGVBill.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Details";
            // 
            // DGVItems
            // 
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Location = new System.Drawing.Point(17, 307);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.RowHeadersWidth = 62;
            this.DGVItems.RowTemplate.Height = 28;
            this.DGVItems.Size = new System.Drawing.Size(844, 214);
            this.DGVItems.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // View_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DGVItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSelectBill);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "View_Bill";
            this.Text = "View Bill";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.Button btnClose;
    }
}