namespace QLYGiayDep
{
    partial class Dangnhap
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
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdql = new System.Windows.Forms.RadioButton();
            this.rdnv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(342, 155);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(327, 26);
            this.txttk.TabIndex = 0;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(342, 217);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(327, 26);
            this.txtmk.TabIndex = 1;
            this.txtmk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(560, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rdql
            // 
            this.rdql.AutoSize = true;
            this.rdql.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdql.Location = new System.Drawing.Point(342, 268);
            this.rdql.Name = "rdql";
            this.rdql.Size = new System.Drawing.Size(97, 26);
            this.rdql.TabIndex = 7;
            this.rdql.TabStop = true;
            this.rdql.Text = "Quản lý";
            this.rdql.UseVisualStyleBackColor = true;
            // 
            // rdnv
            // 
            this.rdnv.AutoSize = true;
            this.rdnv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnv.Location = new System.Drawing.Point(544, 267);
            this.rdnv.Name = "rdnv";
            this.rdnv.Size = new System.Drawing.Size(115, 26);
            this.rdnv.TabIndex = 8;
            this.rdnv.TabStop = true;
            this.rdnv.Text = "Nhân viên";
            this.rdnv.UseVisualStyleBackColor = true;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdnv);
            this.Controls.Add(this.rdql);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Name = "Dangnhap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdql;
        private System.Windows.Forms.RadioButton rdnv;
    }
}

