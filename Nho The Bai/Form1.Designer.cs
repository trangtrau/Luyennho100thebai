namespace Nho_The_Bai
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
            this.button1 = new System.Windows.Forms.Button();
            this.labSo = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.labKetQua = new System.Windows.Forms.Label();
            this.labNoiDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labSo
            // 
            this.labSo.AutoSize = true;
            this.labSo.Location = new System.Drawing.Point(19, 25);
            this.labSo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labSo.Name = "labSo";
            this.labSo.Size = new System.Drawing.Size(64, 25);
            this.labSo.TabIndex = 2;
            this.labSo.Text = "label1";
            this.labSo.Click += new System.EventHandler(this.labSo_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(164, 25);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(6);
            this.txtNhap.MaximumSize = new System.Drawing.Size(396, 50);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(240, 30);
            this.txtNhap.TabIndex = 3;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // labKetQua
            // 
            this.labKetQua.AutoSize = true;
            this.labKetQua.Location = new System.Drawing.Point(81, 156);
            this.labKetQua.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labKetQua.Name = "labKetQua";
            this.labKetQua.Size = new System.Drawing.Size(0, 25);
            this.labKetQua.TabIndex = 4;
            // 
            // labNoiDung
            // 
            this.labNoiDung.AutoSize = true;
            this.labNoiDung.Location = new System.Drawing.Point(83, 212);
            this.labNoiDung.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labNoiDung.Name = "labNoiDung";
            this.labNoiDung.Size = new System.Drawing.Size(0, 25);
            this.labNoiDung.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.labNoiDung);
            this.Controls.Add(this.labKetQua);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.labSo);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện Nhớ Thẻ ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labSo;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label labKetQua;
        private System.Windows.Forms.Label labNoiDung;
    }
}

