namespace QLHD.BillManagementWinApp
{
    partial class Main
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hóa đơn tiền điện";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(425, 91);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(250, 36);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "Khách hàng nước ngoài";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(304, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVN
            // 
            this.btnVN.Location = new System.Drawing.Point(62, 91);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(250, 36);
            this.btnVN.TabIndex = 4;
            this.btnVN.Text = "Khách hàng Việt Nam";
            this.btnVN.UseVisualStyleBackColor = true;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 257);
            this.Controls.Add(this.btnVN);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnFor;
        private Button btnClose;
        private Button btnVN;
    }
}