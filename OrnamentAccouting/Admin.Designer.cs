namespace OrnamentAccouting
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.billbtn = new System.Windows.Forms.Button();
            this.stockbtn = new System.Windows.Forms.Button();
            this.currentbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sve = new System.Windows.Forms.Button();
            this.transactionbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // billbtn
            // 
            this.billbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.billbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billbtn.Location = new System.Drawing.Point(12, 23);
            this.billbtn.Name = "billbtn";
            this.billbtn.Size = new System.Drawing.Size(248, 95);
            this.billbtn.TabIndex = 0;
            this.billbtn.Text = "Billing";
            this.billbtn.UseVisualStyleBackColor = false;
            this.billbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stockbtn
            // 
            this.stockbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.stockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.stockbtn.Location = new System.Drawing.Point(12, 154);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(248, 95);
            this.stockbtn.TabIndex = 1;
            this.stockbtn.Text = "Stock Entry";
            this.stockbtn.UseVisualStyleBackColor = false;
            this.stockbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentbtn
            // 
            this.currentbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.currentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.currentbtn.Location = new System.Drawing.Point(12, 411);
            this.currentbtn.Name = "currentbtn";
            this.currentbtn.Size = new System.Drawing.Size(248, 95);
            this.currentbtn.TabIndex = 2;
            this.currentbtn.Text = "Current price (Value/gram)";
            this.currentbtn.UseVisualStyleBackColor = false;
            this.currentbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 537);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(80, 565);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(116, 43);
            this.sve.TabIndex = 4;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Visible = false;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // transactionbtn
            // 
            this.transactionbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.transactionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionbtn.Location = new System.Drawing.Point(12, 287);
            this.transactionbtn.Name = "transactionbtn";
            this.transactionbtn.Size = new System.Drawing.Size(248, 95);
            this.transactionbtn.TabIndex = 5;
            this.transactionbtn.Text = "Show Transaction";
            this.transactionbtn.UseVisualStyleBackColor = false;
            this.transactionbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 672);
            this.Controls.Add(this.transactionbtn);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currentbtn);
            this.Controls.Add(this.stockbtn);
            this.Controls.Add(this.billbtn);
            this.Name = "Admin";
            this.Text = "Alankara";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button billbtn;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.Button currentbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.Button transactionbtn;
    }
}

