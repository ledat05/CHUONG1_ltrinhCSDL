using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BT01
{
    public partial class Form1 : Form
    {
        //Khai bao cac doi tuong
        //1.Khai bao 1 bien (doi tuong) Dataset
        DataSet ds = new DataSet();
        //2.Khai bao
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");
        int stt = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tao cau truc datatable
            Tao_Cau_Truc_Cac_Bang();
            Moc_noi_quan_he_cac_Bang();
            Nhap_Lieu_cac_Bang();
            Khoi_Tao_combo_khoa();
            btnDau.PerformClick();
        }

        private void Khoi_Tao_combo_khoa()
        {
         cboKhoa.DisplayMember = "TenKH";
            cboKhoa.ValueMember= "MaKH";
            cboKhoa.DataSource = "tblKhoa";
        }
        public void Gandulieu(int stt)
        {
            DataRow rsv = tblSinhVien.Rows[stt];
            txtMasv.Text = rsv["Masv"].ToString();
            txtHo.Text = rsv["Hosv"].ToString();
            txtTen.Text = rsv["Tensv"].ToString();
            ChkPhai.Checked = (Boolean)rsv["Phai"];
            dtpNgaySinh.Text = rsv["NgaySinh"].ToString();
            txtNoiSinh.Text = rsv["NoiSinh"].ToString();
            cboKhoa.SelectedValue = rsv["Makh"].ToString() ;
            txtHocBong.Text = rsv["HocBong"].ToString();

            lblstt.Text=(stt+1)+"/"+tblSinhVien.Rows.Count;
        }
        private void Nhap_Lieu_cac_Bang()
        {
            NhapLieu_tblSinhVien();
            NhapLieu_tblKhoa();
            NhapLieu_tblKetQua();
        }

        private void NhapLieu_tblKetQua()
        {
            string[] Mang_Ket_Qua = File.ReadAllLines(@"..\..\..\data\ketqua.txt");
            foreach (string Chuoi_ket_qua in Mang_Ket_Qua)
            {
                // Tach chuoi sv thanh cac thanh phan tuong ung
                string[] Mang_Thanh_Phan = Chuoi_ket_qua.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //Tao dong moi co cau truc
                DataRow rkq = tblKetQua.NewRow();
                //Gan du lieu cho cac cot vua moi tao ra
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                    rkq[i] = Mang_Thanh_Phan[i];

                //Them dong vua tao tblsinhvien
                tblKhoa.Rows.Add(rkq);
            }    
        }

        private void NhapLieu_tblKhoa()
        {
            string[] Mang_khoa = File.ReadAllLines(@"..\..\..\data\khoa.txt");
            foreach (string Chuoi_khoa in Mang_khoa)
            {
                //Tach chuoi sv thanh cac thanh phan tuong ung
                string[] Mang_Thanh_Phan = Chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //Tao dong moi co cau truc
                DataRow rkh = tblKhoa.NewRow();
                //Gan du lieu cho cac cot vua moi tao ra
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                    rkh[i] = Mang_Thanh_Phan[i];

                //Them dong vua tao tblsinhvien
                tblKhoa.Rows.Add(rkh);
            }    
        }

        private void NhapLieu_tblSinhVien()
        {
            //Nhập liệu cho tblsinhvien;
            string[] Mang_sv = File.ReadAllLines(@"..\..\..\data\sinhvien.txt");
            foreach(string Chuoi_sv in Mang_sv)
            {
                //Tach chuoi sv thanh cac thanh phan tuong ung
                string[] Mang_Thanh_Phan = Chuoi_sv.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //Tao dong moi co cau truc
                DataRow rsv = tblSinhVien.NewRow();
                //Gan du lieu cho cac cot vua moi tao ra
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                    rsv[i] = Mang_Thanh_Phan[i];

                //Them dong vua tao tblsinhvien
                tblSinhVien.Rows.Add(rsv);
            }    
        }

        private void Moc_noi_quan_he_cac_Bang()
        {
            //  Tao quan he giua tblKHoa va tblSinhVien
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);
            //Tạo quan hệ giữa tblsinhvien va tblketqua
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"], true);
            //loại bỏ cacase deleto trong quan he
            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;

        }

        private void Tao_Cau_Truc_Cac_Bang()
        {
            //Tao cau truc cho datatable
            tblKhoa.Columns.Add("Masv", typeof(string));
            tblKhoa.Columns.Add("TenKh", typeof(string));
            //Tao Khoa chinh cho tblkhoa
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["Makh"] };
            //Tạo cấu trúc cho datatble
            tblSinhVien.Columns.Add("MaSv", typeof(string));
            tblSinhVien.Columns.Add("HoSv", typeof(string));
            tblSinhVien.Columns.Add("TenSv", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKh", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));
            //Tao Khoa chinh cho TBLSINHVIEN
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSv"] };
            //Tao cau truc cho datatable tuong ung
            tblKetQua.Columns.Add("MaSv", typeof(string));
            tblKetQua.Columns.Add("MaKh", typeof(string));
            tblKetQua.Columns.Add("Diem", typeof(double));
            //Tao khoa chinh cho tblketqua
            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSv"], tblKetQua.Columns["MaKh"] };
            //Thêm đồng thời nhiểu datatable vao dataset
            ds.Tables.AddRange(new DataTable[] { tblKhoa, tblSinhVien, tblKetQua });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            stt = 0;
            Gandulieu(stt);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            stt = tblSinhVien.Rows.Count-1;
            Gandulieu(stt);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (stt == 0) return;
            stt--;
            Gandulieu(stt);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if(stt == tblSinhVien.Rows.Count-1) return;
            stt++;
            Gandulieu(stt);
        }
    }
}
