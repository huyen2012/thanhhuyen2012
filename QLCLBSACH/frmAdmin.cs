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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
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
        public void DuLieu_TacGia()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MATG, TENTG From TACGIA");
            DataGrid_TacGia.DataSource = dta;
            Hienthi_DuLieu1();
        }
        public void DuLieu_TheLoai()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MATL, TENTL From THELOAI");
            DataGrid_TheLoai.DataSource = dta;
            Hienthi_DuLieu3();
        }
        public void DuLieu_NXB()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MANXB, TENNXB From NXB");
            DataGrid_NXB.DataSource = dta;
            Hienthi_DuLieu2();
        }
        public void DuLieu_Sach()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MASACH, TENSACH, MATG, MATL, MANXB, NAMXB, NGONNGU From SACH");
            DataGrid_Sach.DataSource = dta;
            Hienthi_DuLieu4();
        }
        public void Hienthi_DuLieu1()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", DataGrid_TacGia.DataSource, "MATG");
            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", DataGrid_TacGia.DataSource, "TENTG"); 
          
        }
        public void Hienthi_DuLieu2()
        {
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", DataGrid_NXB.DataSource, "MANXB");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", DataGrid_NXB.DataSource, "TENNXB");
        }
        public void Hienthi_DuLieu3()
        {
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", DataGrid_TheLoai.DataSource, "MATL");
            txtTheLoai.DataBindings.Clear();
            txtTheLoai.DataBindings.Add("Text", DataGrid_TheLoai.DataSource, "TENTL");
        }
        public void Hienthi_DuLieu4()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", DataGrid_Sach.DataSource, "MASACH");
            txtSach.DataBindings.Clear();
            txtSach.DataBindings.Add("Text", DataGrid_Sach.DataSource, "TENSACH");
            cboTG.DataBindings.Clear();
            cboTG.DataBindings.Add("Text", DataGrid_Sach.DataSource, "MATG");
            cboTL.DataBindings.Clear();
            cboTL.DataBindings.Add("Text", DataGrid_Sach.DataSource, "MATL");
            cboNXB.DataBindings.Clear();
            cboNXB.DataBindings.Add("Text", DataGrid_Sach.DataSource, "MANXB");
            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", DataGrid_Sach.DataSource, "NAMXB");
            txtNN.DataBindings.Clear();
            txtNN.DataBindings.Add("Text", DataGrid_Sach.DataSource, "NGONNGU");
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            DataTable dta1 = kn.Lay_Dulieu("Select MATG from TACGIA");
            cboTG.DataSource = dta1;
            cboTG.DisplayMember = "MATG";
            cboTG.ValueMember = "MATG";
            DataTable dta2 = kn.Lay_Dulieu("Select MATL from THELOAI");
            cboTL.DataSource = dta2;
            cboTL.DisplayMember = "MATL";
            cboTL.ValueMember = "MATL";
            DataTable dta3 = kn.Lay_Dulieu("Select MANXB from NXB");
            cboNXB.DataSource = dta3;
            cboNXB.DisplayMember = "MANXB";
            cboNXB.ValueMember = "MANXB";
            DuLieu_TacGia();
            DuLieu_TheLoai();
            DuLieu_NXB();
            DuLieu_Sach();
        }

        private void btnMoiTG_Click(object sender, EventArgs e)
        {
            txtMaTG.Text = "";
            txtTacGia.Text = "";
            txtMaTG.Focus();
        }

        private void btnMoiTL_Click(object sender, EventArgs e)
        {
            txtMaTL.Text = "";
            txtTheLoai.Text = "";
            txtMaTL.Focus();
        }

        private void btnMoiNXB_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = "";
            txtNXB.Text = "";
            txtMaNXB.Focus();
        }

        private void btnMoiSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtSach.Text = "";
            txtNamXB.Text = "";
            txtNN.Text = "";
            txtMaSach.Focus();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            string sql_them = "Insert into TACGIA Values ('" + txtMaTG.Text + "','" + txtTacGia.Text + "')";
            kn.Execute(sql_them);
            DuLieu_TacGia();
            DialogResult thongbaothem;
            thongbaothem = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string sql_them = "Insert into THELOAI Values ('" + txtMaTL.Text + "','" + txtTheLoai.Text + "')";
            kn.Execute(sql_them);
            DuLieu_TheLoai();
            DialogResult thongbaothem;
            thongbaothem = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            string sql_them = "Insert into NXB Values ('" + txtMaNXB.Text + "','" + txtNXB.Text + "')";
            kn.Execute(sql_them);
            DuLieu_NXB();
            DialogResult thongbaothem;
            thongbaothem = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string sql_them = "Insert into SACH Values ('" + txtMaSach.Text + "','" + txtSach.Text + "','" + cboTG.Text + "','" + cboTL.Text + "','" + cboNXB.Text + "','" + txtNamXB.Text + "','" + txtNN.Text + "')";
            kn.Execute(sql_them);
            DuLieu_Sach();
            DialogResult thongbaothem;
            thongbaothem = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update TACGIA Set TENTG ='" + txtTacGia.Text + "'";
            sql_sua = sql_sua + ", MATG ='" + txtMaTG.Text + "' where MATG = '" + txtMaTG.Text + "'";
            kn.Execute(sql_sua);
            DuLieu_TacGia();
            DialogResult sua;
            sua = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update THELOAI Set TENTL ='" + txtTheLoai.Text + "'";
            sql_sua = sql_sua + ", MATL ='" + txtMaTL.Text + "' where MATL = '" + txtMaTL.Text + "'";
            kn.Execute(sql_sua);
            DuLieu_TheLoai();
            DialogResult sua;
            sua = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update NXB Set TENNXB ='" + txtNXB.Text + "'";
            sql_sua = sql_sua + ", MANXB ='" + txtMaNXB.Text + "' where MANXB = '" + txtMaNXB.Text + "'";
            kn.Execute(sql_sua);
            DuLieu_NXB();
            DialogResult sua;
            sua = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string sql_sua1 = "Update SACH Set TENSACH ='" + txtSach.Text + "'";
            sql_sua1 = sql_sua1 + ", MASACH ='" + txtMaSach.Text + "' where MASACH = '" + txtMaSach.Text + "'";
            string sql_sua2 = "Update SACH Set NGONNGU ='" + txtNN.Text + "'";
            sql_sua2 = sql_sua2 + ", NAMXB ='" + txtNamXB.Text + "' where MASACH = '" + txtMaSach.Text + "'";
            kn.Execute(sql_sua1);
            kn.Execute(sql_sua2);
            DuLieu_Sach();
            DialogResult sua;
            sua = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete TACGIA Where MATG = '" + txtMaTG.Text + "'");
            DuLieu_TacGia();
            DialogResult xoa;
            xoa = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete THELOAI Where MATL = '" + txtMaTL.Text + "'");
            DuLieu_TheLoai();
            DialogResult xoa;
            xoa = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete NXB Where MANXB = '" + txtMaNXB.Text + "'");
            DuLieu_NXB();
            DialogResult xoa;
            xoa = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete SACH Where MASACH = '" + txtMaSach.Text + "'");
            DuLieu_Sach();
            DialogResult xoa;
            xoa = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            DataTable dta4 = kn.Lay_Dulieu("Select MATG from TACGIA");
            cboTG.DataSource = dta4;
            cboTG.DisplayMember = "MATG";
            cboTG.ValueMember = "MATG";
            DataTable dta5 = kn.Lay_Dulieu("Select MATL from THELOAI");
            cboTL.DataSource = dta5;
            cboTL.DisplayMember = "MATL";
            cboTL.ValueMember = "MATL";
            DataTable dta6 = kn.Lay_Dulieu("Select MANXB from NXB");
            cboNXB.DataSource = dta6;
            cboNXB.DisplayMember = "MANXB";
            cboNXB.ValueMember = "MANXB";
        }
    }
}
