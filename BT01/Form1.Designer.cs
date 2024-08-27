
namespace BT01
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
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.ChkPhai = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.lblstt = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(116, 5);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(293, 32);
            this.txtMasv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên Sv";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(116, 39);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(153, 32);
            this.txtHo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Sinh";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nơi Sinh";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(116, 171);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(293, 32);
            this.txtNoiSinh.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khoa";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Học Bổng";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHocBong
            // 
            this.txtHocBong.Location = new System.Drawing.Point(116, 250);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(293, 32);
            this.txtHocBong.TabIndex = 2;
            this.txtHocBong.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng Điểm";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(116, 297);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(293, 32);
            this.txtTongDiem.TabIndex = 2;
            this.txtTongDiem.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(275, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(134, 32);
            this.txtTen.TabIndex = 2;
            // 
            // ChkPhai
            // 
            this.ChkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkPhai.Location = new System.Drawing.Point(31, 73);
            this.ChkPhai.Name = "ChkPhai";
            this.ChkPhai.Size = new System.Drawing.Size(99, 43);
            this.ChkPhai.TabIndex = 3;
            this.ChkPhai.Text = "Phái";
            this.ChkPhai.UseVisualStyleBackColor = true;
            this.ChkPhai.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(116, 123);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(293, 32);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDau.Location = new System.Drawing.Point(27, 351);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(65, 29);
            this.btnDau.TabIndex = 5;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTruoc.Location = new System.Drawing.Point(109, 351);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(65, 29);
            this.btnTruoc.TabIndex = 5;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSau.Location = new System.Drawing.Point(259, 351);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(65, 29);
            this.btnSau.TabIndex = 5;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCuoi.Location = new System.Drawing.Point(341, 351);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(65, 29);
            this.btnCuoi.TabIndex = 5;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // lblstt
            // 
            this.lblstt.AutoSize = true;
            this.lblstt.Location = new System.Drawing.Point(191, 356);
            this.lblstt.Name = "lblstt";
            this.lblstt.Size = new System.Drawing.Size(62, 24);
            this.lblstt.TabIndex = 1;
            this.lblstt.Text = "00/00";
            this.lblstt.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(27, 397);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Location = new System.Drawing.Point(123, 397);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 29);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGhi.Location = new System.Drawing.Point(219, 397);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(90, 29);
            this.btnGhi.TabIndex = 5;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnKhong
            // 
            this.btnKhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKhong.Location = new System.Drawing.Point(315, 397);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(90, 29);
            this.btnKhong.TabIndex = 5;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(116, 212);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(293, 32);
            this.cboKhoa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 452);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.ChkPhai);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblstt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox ChkPhai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Label lblstt;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.ComboBox cboKhoa;
    }
}

