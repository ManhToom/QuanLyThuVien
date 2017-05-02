using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.BUSLayer;

namespace GUI.UC.Tab
{
    public partial class DocGia : UserControl
    {
        public DocGia()
        {
            InitializeComponent();
        }
        
        private void disableInput()
        {
            txtmadg.Enabled = false;
            txtten.Enabled = false;
            date1.Enabled = false;
            groupBox1.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            cbxloai.Enabled = false;
        }

        private void enableInput()
        {
            txtmadg.Enabled = true;
            txtten.Enabled = true;
            date1.Enabled = true;
            groupBox1.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            cbxloai.Enabled = true;
        }

        private void clearInput()
        {
            txtmadg.Clear();
            txtten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            cbxloai.Text = "Đọc";
            rdbnam.Checked = true;
            rdbnu.Checked = false;
        }

        private void loadDataToDgv()
        {
            dgvDocGia.DataSource = BUS.xuat_DG();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
            disableInput();
            btnSua.Enabled = false;
            cbxloai.Items.Add("Đọc");
            cbxloai.Items.Add("Mượn/Đọc");
        }

        private void loadToText()
        {
            txtmadg.Text = dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvDocGia.CurrentRow.Cells[1].Value.ToString();
            if (dgvDocGia.CurrentRow.Cells[2].Value.ToString() == "Nam") rdbnam.Checked = true;
            else if (dgvDocGia.CurrentRow.Cells[2].Value.ToString() == "Nữ") rdbnu.Checked = true;
            date1.Text = dgvDocGia.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = dgvDocGia.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dgvDocGia.CurrentRow.Cells[5].Value.ToString();
            cbxloai.Text = dgvDocGia.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableInput();
            loadToText();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Text = "Xóa";
            btnXoa.Active = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();
            btnSua.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           enableInput();
            txtmadg.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Active || btnSua.Active)
            {
                clearInput();
                disableInput();
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                if (BUS.xoa_DG(txtmadg.Text) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadDataToDgv();
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInput();
                disableInput();
		}
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThem.Active)
                {
					QLThuVien.ValueObject.DocGia a = new QLThuVien.ValueObject.DocGia();
                    a.MaDG = txtmadg.Text.Trim();
                    a.TenDG = txtten.Text.Trim();
                    a.NgaySinh = date1.Value;
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    a.LoaiDG = cbxloai.Text.Trim();
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaDG == null || a.MaDG == "") throw new Exception();
                    if (BUS.them_DG(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();

                }
                else if (btnSua.Active)
                {
					QLThuVien.ValueObject.DocGia a = new QLThuVien.ValueObject.DocGia();
                    a.MaDG = txtmadg.Text.Trim();
                    a.TenDG = txtten.Text.Trim();
                    a.NgaySinh = date1.Value;
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    a.LoaiDG = cbxloai.Text.Trim();
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaDG == null || a.MaDG == "") throw new Exception();
                    if (BUS.sua_DG(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Sửa Thành Công");
                    }
                    else throw new Exception();
                }
                
            }
            catch
            {
                MessageBox.Show("Input sai");
            }
            finally
            {
                clearInput();
                disableInput();
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Text = "Xóa";
            }
        }
    }
}
