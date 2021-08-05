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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dangky;
            dangky = MessageBox.Show("Bạn có muốn đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dangky == DialogResult.Yes)
            {
                string sql_dky = "Insert into THANHVIEN Values ('" + txtMSV.Text + "','" + txtHoTen.Text + "','" + txtMatKhau.Text + "','" + txtDiaChi.Text + "','" + txtEmail.Text + "','" + lblQuyen.Text +"')";
                kn.Execute(sql_dky);
                DialogResult thongbaodky;
                thongbaodky = MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form Fm1 = new frmDangNhap();
                Fm1.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}
