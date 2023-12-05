
namespace MicroProject
{
    partial class Form1
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
            this.linItems = new System.Windows.Forms.LinkLabel();
            this.linkUser = new System.Windows.Forms.LinkLabel();
            this.linkBill = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linItems
            // 
            this.linItems.AutoSize = true;
            this.linItems.Location = new System.Drawing.Point(0, 0);
            this.linItems.Name = "linItems";
            this.linItems.Size = new System.Drawing.Size(76, 29);
            this.linItems.TabIndex = 0;
            this.linItems.TabStop = true;
            this.linItems.Text = "ltems";
            this.linItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linItems_LinkClicked);
            // 
            // linkUser
            // 
            this.linkUser.AutoSize = true;
            this.linkUser.Location = new System.Drawing.Point(71, 0);
            this.linkUser.Name = "linkUser";
            this.linkUser.Size = new System.Drawing.Size(68, 29);
            this.linkUser.TabIndex = 1;
            this.linkUser.TabStop = true;
            this.linkUser.Text = "User";
            // 
            // linkBill
            // 
            this.linkBill.AutoSize = true;
            this.linkBill.Location = new System.Drawing.Point(135, 0);
            this.linkBill.Name = "linkBill";
            this.linkBill.Size = new System.Drawing.Size(51, 29);
            this.linkBill.TabIndex = 2;
            this.linkBill.TabStop = true;
            this.linkBill.Text = "Bill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MicroProject.Properties.Resources.j35;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 526);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkBill);
            this.Controls.Add(this.linkUser);
            this.Controls.Add(this.linItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linItems;
        private System.Windows.Forms.LinkLabel linkUser;
        private System.Windows.Forms.LinkLabel linkBill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

