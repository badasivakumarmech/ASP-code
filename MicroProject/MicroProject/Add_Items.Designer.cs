
namespace MicroProject
{
    partial class Add_Items
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
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVItems
            // 
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Location = new System.Drawing.Point(0, 0);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.RowHeadersWidth = 62;
            this.DGVItems.RowTemplate.Height = 28;
            this.DGVItems.Size = new System.Drawing.Size(459, 349);
            this.DGVItems.TabIndex = 0;
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(252, 375);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(160, 35);
            this.txtItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Price";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(95, 375);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(132, 29);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Enter Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(252, 430);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 35);
            this.txtPrice.TabIndex = 7;
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 556);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.DGVItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Add_Items";
            this.Text = "Add Items";
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPrice;
    }
}