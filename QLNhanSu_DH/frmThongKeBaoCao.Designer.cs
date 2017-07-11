namespace QLNhanSu_DH
{
    partial class frmThongKeBaoCao
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
            this.btTKNhanSu = new System.Windows.Forms.Button();
            this.btTKKhenThuong = new System.Windows.Forms.Button();
            this.btTKKyLuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // btTKNhanSu
            // 
            this.btTKNhanSu.BackColor = System.Drawing.Color.Navy;
            this.btTKNhanSu.FlatAppearance.BorderSize = 0;
            this.btTKNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKNhanSu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTKNhanSu.ForeColor = System.Drawing.Color.White;
            this.btTKNhanSu.Location = new System.Drawing.Point(52, 93);
            this.btTKNhanSu.Name = "btTKNhanSu";
            this.btTKNhanSu.Size = new System.Drawing.Size(400, 104);
            this.btTKNhanSu.TabIndex = 1;
            this.btTKNhanSu.Text = "THỐNG KÊ TẤT CẢ NHÂN SỰ";
            this.btTKNhanSu.UseVisualStyleBackColor = false;
            this.btTKNhanSu.Click += new System.EventHandler(this.btTKNhanSu_Click);
            // 
            // btTKKhenThuong
            // 
            this.btTKKhenThuong.BackColor = System.Drawing.Color.Navy;
            this.btTKKhenThuong.FlatAppearance.BorderSize = 0;
            this.btTKKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKKhenThuong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTKKhenThuong.ForeColor = System.Drawing.Color.White;
            this.btTKKhenThuong.Location = new System.Drawing.Point(52, 222);
            this.btTKKhenThuong.Name = "btTKKhenThuong";
            this.btTKKhenThuong.Size = new System.Drawing.Size(186, 104);
            this.btTKKhenThuong.TabIndex = 1;
            this.btTKKhenThuong.Text = "THỐNG KÊ KHEN THƯỞNG";
            this.btTKKhenThuong.UseVisualStyleBackColor = false;
            this.btTKKhenThuong.Click += new System.EventHandler(this.btTKKhenThuong_Click);
            // 
            // btTKKyLuat
            // 
            this.btTKKyLuat.BackColor = System.Drawing.Color.Navy;
            this.btTKKyLuat.FlatAppearance.BorderSize = 0;
            this.btTKKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKKyLuat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTKKyLuat.ForeColor = System.Drawing.Color.White;
            this.btTKKyLuat.Location = new System.Drawing.Point(266, 222);
            this.btTKKyLuat.Name = "btTKKyLuat";
            this.btTKKyLuat.Size = new System.Drawing.Size(186, 104);
            this.btTKKyLuat.TabIndex = 1;
            this.btTKKyLuat.Text = "THỐNG KÊ KỶ LUẬT";
            this.btTKKyLuat.UseVisualStyleBackColor = false;
            this.btTKKyLuat.Click += new System.EventHandler(this.btTKKyLuat_Click);
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(512, 382);
            this.Controls.Add(this.btTKKyLuat);
            this.Controls.Add(this.btTKKhenThuong);
            this.Controls.Add(this.btTKNhanSu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmThongKeBaoCao";
            this.Text = "ThốngKê & Báo Cáo";
            this.Load += new System.EventHandler(this.frmThongKeBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTKNhanSu;
        private System.Windows.Forms.Button btTKKhenThuong;
        private System.Windows.Forms.Button btTKKyLuat;
    }
}