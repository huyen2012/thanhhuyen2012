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
    public partial class frmSuaThanhVien : Form
    {
        public frmSuaThanhVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbaosua;
            thongbaosua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbaosua == DialogResult.Yes)
            {
                string sql_sua1 = "Update THANHVIEN Set MATKHAU ='" + txtMatKhau.Text + "'";
                sql_sua1 = sql_sua1 + ", TENTV ='" + txtHoTen.Text + "' where MATV = '" + txtMSV.Text + "'";
                string sql_sua2 = "Update THANHVIEN Set DIACHI ='" + txtDiaChi.Text + "'";
                sql_sua2 = sql_sua2 + ", EMAIL ='" + txtEmail.Text + "' where MATV = '" + txtMSV.Text + "'";
                kn.Execute(sql_sua1);
                kn.Execute(sql_sua2);
                DialogResult sua;
                sua = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }
    }
}
