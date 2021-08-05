using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLCLBSACH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap dn = new KiemTraDangNhap();
            if (dn.CheckLogin(txtMSV.Text, txtMatKhau.Text, cboQuyen.Text) == 1)
            {
                if (this.cboQuyen.Text == "ADMIN")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form Fm = new frmAdmin();
                    Fm.Show();
                    this.Hide();
                }
                if (this.cboQuyen.Text == "THANHVIEN")
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Form Fm1 = new frmTrangChu();
                    Fm1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select MAQUYENDN from QUYENDANGNHAP");
            cboQuyen.DataSource = dta;
            cboQuyen.DisplayMember = "MAQUYENDN";
            cboQuyen.ValueMember = "MAQUYENDN";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Fm1 = new frmDangKy();
            Fm1.Show();
            this.Hide();
        }
    }
}
