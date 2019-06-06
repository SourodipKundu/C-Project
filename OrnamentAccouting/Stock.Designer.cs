namespace OrnamentAccouting
{
    partial class Stock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prctxt = new System.Windows.Forms.TextBox();
            this.weighttxt = new System.Windows.Forms.TextBox();
            this.prdtxt = new System.Windows.Forms.TextBox();
            this.svestbutton = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // prctxt
            // 
            this.prctxt.Location = new System.Drawing.Point(326, 65);
            this.prctxt.Name = "prctxt";
            this.prctxt.Size = new System.Drawing.Size(195, 22);
            this.prctxt.TabIndex = 5;
            // 
            // weighttxt
            // 
            this.weighttxt.Location = new System.Drawing.Point(326, 183);
            this.weighttxt.Name = "weighttxt";
            this.weighttxt.Size = new System.Drawing.Size(195, 22);
            this.weighttxt.TabIndex = 8;
            // 
            // prdtxt
            // 
            this.prdtxt.Location = new System.Drawing.Point(326, 124);
            this.prdtxt.Name = "prdtxt";
            this.prdtxt.Size = new System.Drawing.Size(195, 22);
            this.prdtxt.TabIndex = 9;
            // 
            // svestbutton
            // 
            this.svestbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svestbutton.Location = new System.Drawing.Point(357, 235);
            this.svestbutton.Name = "svestbutton";
            this.svestbutton.Size = new System.Drawing.Size(131, 41);
            this.svestbutton.TabIndex = 10;
            this.svestbutton.Text = "Save";
            this.svestbutton.UseVisualStyleBackColor = true;
            this.svestbutton.Click += new System.EventHandler(this.Svestbutton_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(216, 312);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(432, 150);
            this.dgv1.TabIndex = 11;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(863, 597);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.svestbutton);
            this.Controls.Add(this.prdtxt);
            this.Controls.Add(this.weighttxt);
            this.Controls.Add(this.prctxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prctxt;
        private System.Windows.Forms.TextBox weighttxt;
        private System.Windows.Forms.TextBox prdtxt;
        private System.Windows.Forms.Button svestbutton;
        private System.Windows.Forms.DataGridView dgv1;
    }
}