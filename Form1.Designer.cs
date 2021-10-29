
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsa = new System.Windows.Forms.TextBox();
            this.btcong = new System.Windows.Forms.Button();
            this.txtsb = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // txtsa
            // 
            this.txtsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsa.Location = new System.Drawing.Point(236, 89);
            this.txtsa.Name = "txtsa";
            this.txtsa.Size = new System.Drawing.Size(297, 39);
            this.txtsa.TabIndex = 1;
            // 
            // btcong
            // 
            this.btcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcong.Location = new System.Drawing.Point(427, 269);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(106, 69);
            this.btcong.TabIndex = 2;
            this.btcong.Text = "Cộng";
            this.btcong.UseVisualStyleBackColor = true;
            // 
            // txtsb
            // 
            this.txtsb.AutoSize = true;
            this.txtsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsb.Location = new System.Drawing.Point(78, 150);
            this.txtsb.Name = "txtsb";
            this.txtsb.Size = new System.Drawing.Size(81, 32);
            this.txtsb.TabIndex = 0;
            this.txtsb.Text = "Số b:";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(78, 208);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(134, 32);
            this.txt.TabIndex = 0;
            this.txt.Text = "Kết Quả :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(236, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 39);
            this.textBox1.TabIndex = 1;
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(236, 201);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(297, 39);
            this.txtkq.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 419);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsa);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtsb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsa;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Label txtsb;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtkq;
    }
}

