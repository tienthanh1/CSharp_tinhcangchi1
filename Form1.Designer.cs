namespace CSharp_tinhcangchi1
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
            this.lblduonglich = new System.Windows.Forms.Label();
            this.lblamlich = new System.Windows.Forms.Label();
            this.txtduonglich = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbstinhcan = new System.Windows.Forms.ListBox();
            this.txtkp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblduonglich
            // 
            this.lblduonglich.AutoSize = true;
            this.lblduonglich.Location = new System.Drawing.Point(41, 51);
            this.lblduonglich.Name = "lblduonglich";
            this.lblduonglich.Size = new System.Drawing.Size(58, 13);
            this.lblduonglich.TabIndex = 0;
            this.lblduonglich.Text = "Dương lịch";
            // 
            // lblamlich
            // 
            this.lblamlich.AutoSize = true;
            this.lblamlich.Location = new System.Drawing.Point(41, 112);
            this.lblamlich.Name = "lblamlich";
            this.lblamlich.Size = new System.Drawing.Size(41, 13);
            this.lblamlich.TabIndex = 1;
            this.lblamlich.Text = "Âm lịch";
            // 
            // txtduonglich
            // 
            this.txtduonglich.Location = new System.Drawing.Point(140, 48);
            this.txtduonglich.Name = "txtduonglich";
            this.txtduonglich.Size = new System.Drawing.Size(100, 20);
            this.txtduonglich.TabIndex = 2;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(338, 41);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbstinhcan
            // 
            this.lbstinhcan.FormattingEnabled = true;
            this.lbstinhcan.Location = new System.Drawing.Point(551, 51);
            this.lbstinhcan.Name = "lbstinhcan";
            this.lbstinhcan.Size = new System.Drawing.Size(202, 238);
            this.lbstinhcan.TabIndex = 4;
            // 
            // txtkp
            // 
            this.txtkp.Location = new System.Drawing.Point(140, 112);
            this.txtkp.Name = "txtkp";
            this.txtkp.Size = new System.Drawing.Size(100, 20);
            this.txtkp.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkp);
            this.Controls.Add(this.lbstinhcan);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtduonglich);
            this.Controls.Add(this.lblamlich);
            this.Controls.Add(this.lblduonglich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblduonglich;
        private System.Windows.Forms.Label lblamlich;
        private System.Windows.Forms.TextBox txtduonglich;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lbstinhcan;
        private System.Windows.Forms.TextBox txtkp;
    }
}

