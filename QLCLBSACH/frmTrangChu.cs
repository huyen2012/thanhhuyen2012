using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCLBSACH
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void Load_DuLieu_TheLoai()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From SACH");
            cboTKtheloai.DataSource = dta;
            cboTKtheloai.DisplayMember = "MATL";
            cboTKtheloai.ValueMember = "MATL";
        }
        public void Load_DuLieu_NgonNgu()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From SACH");
            cboTKngonngu.DataSource = dta;
            cboTKngonngu.DisplayMember = "NGONNGU";
            cboTKngonngu.ValueMember = "NGONNGU";
        }

        private void chkTKnxb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabpageTK_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (chkTKsach.Checked == true)
            {
                sqltk = "Select * from SACH where TENSACH like '" + txtTKsach.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (chkTKtacgia.Checked == true)
            {
                sqltk = "Select * from SACH where MATG like '" + txtTKtacgia.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (chkTKtheloai.Checked == true)
            {
                sqltk = "Select * from SACH where MATL like '" + cboTKtheloai.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (chkTKnxb.Checked == true)
            {
                sqltk = "Select * from SACH where MANXB like '" + txtTKnxb.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (chkTKngonngu.Checked == true)
            {
                sqltk = "Select * from SACH where NGONNGU like '" + cboTKngonngu.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            DataGrid_TimKiem.DataSource = dta;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            Load_DuLieu_NgonNgu();
            Load_DuLieu_TheLoai();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                Form Fm = new frmDangNhap();
                Fm.Show();
                this.Hide();
            }
                
        }
    }
}
