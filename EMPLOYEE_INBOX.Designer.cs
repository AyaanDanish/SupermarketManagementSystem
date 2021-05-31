
namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    partial class EMPLOYEE_INBOX
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
            this.INBOX = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // INBOX
            // 
            this.INBOX.AutoSize = true;
            this.INBOX.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INBOX.Location = new System.Drawing.Point(13, 22);
            this.INBOX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.INBOX.Name = "INBOX";
            this.INBOX.Size = new System.Drawing.Size(99, 36);
            this.INBOX.TabIndex = 0;
            this.INBOX.Text = "INBOX";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(567, 370);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // EMPLOYEE_INBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(600, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.INBOX);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EMPLOYEE_INBOX";
            this.Text = "Employee Inbox";
            this.Load += new System.EventHandler(this.EMPLOYEE_INBOX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label INBOX;
        private System.Windows.Forms.TextBox textBox1;
    }
}