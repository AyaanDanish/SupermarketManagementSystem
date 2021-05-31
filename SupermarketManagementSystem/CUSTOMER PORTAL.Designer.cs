
namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    partial class CUSTOMER_PORTAL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.membership = new System.Windows.Forms.Button();
            this.update_acc = new System.Windows.Forms.Button();
            this.store = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.membership);
            this.panel1.Controls.Add(this.update_acc);
            this.panel1.Controls.Add(this.store);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 307);
            this.panel1.TabIndex = 0;
            // 
            // membership
            // 
            this.membership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membership.Location = new System.Drawing.Point(33, 60);
            this.membership.Name = "membership";
            this.membership.Size = new System.Drawing.Size(193, 188);
            this.membership.TabIndex = 1;
            this.membership.Text = "MEMBERSHIP";
            this.membership.UseVisualStyleBackColor = true;
            // 
            // update_acc
            // 
            this.update_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_acc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_acc.Location = new System.Drawing.Point(248, 60);
            this.update_acc.Name = "update_acc";
            this.update_acc.Size = new System.Drawing.Size(203, 188);
            this.update_acc.TabIndex = 2;
            this.update_acc.Text = "UPDATE ACC DETAILS";
            this.update_acc.UseVisualStyleBackColor = true;
            this.update_acc.Click += new System.EventHandler(this.update_acc_Click);
            // 
            // store
            // 
            this.store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.store.Location = new System.Drawing.Point(494, 60);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(193, 188);
            this.store.TabIndex = 3;
            this.store.Text = "STORE";
            this.store.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(750, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 188);
            this.button4.TabIndex = 4;
            this.button4.Text = "PURCHASE HISTORY";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME,";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(256, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CUSTOMER_PORTAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(997, 525);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "CUSTOMER_PORTAL";
            this.Text = "CUSTOMER_PORTAL";
            this.Load += new System.EventHandler(this.CUSTOMER_PORTAL_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button membership;
        private System.Windows.Forms.Button update_acc;
        private System.Windows.Forms.Button store;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}