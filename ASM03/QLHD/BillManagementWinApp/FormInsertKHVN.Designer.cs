namespace QLHD.BillManagementWinApp
{
    partial class FormInsertKHVN
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDinhMuc = new System.Windows.Forms.TextBox();
            this.txtLoaiKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm khách hàng Việt Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Định mức";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(262, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(103, 90);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(115, 23);
            this.txtMaKH.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(103, 138);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(115, 23);
            this.txtHoTen.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(103, 181);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(115, 23);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(308, 138);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 23);
            this.txtSoLuong.TabIndex = 14;
            // 
            // txtDinhMuc
            // 
            this.txtDinhMuc.Location = new System.Drawing.Point(308, 181);
            this.txtDinhMuc.Name = "txtDinhMuc";
            this.txtDinhMuc.Size = new System.Drawing.Size(115, 23);
            this.txtDinhMuc.TabIndex = 15;
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.FormattingEnabled = true;
            this.txtLoaiKH.Items.AddRange(new object[] {
            "Sinh hoạt",
            "Kinh doanh",
            "Sản xuất"});
            this.txtLoaiKH.Location = new System.Drawing.Point(308, 90);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(115, 23);
            this.txtLoaiKH.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(103, 231);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(115, 23);
            this.txtDiaChi.TabIndex = 19;
            // 
            // FormInsertKHVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 403);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoaiKH);
            this.Controls.Add(this.txtDinhMuc);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertKHVN";
            this.Text = "FormInsertKHVN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtMaKH;
        private TextBox txtHoTen;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtDinhMuc;
        private ComboBox txtLoaiKH;
        private Label label5;
        private TextBox txtDiaChi;
    }
}