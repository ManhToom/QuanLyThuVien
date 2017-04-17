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
    public partial class CuonSach : UserControl
    {
        public CuonSach()
        {
            InitializeComponent();
        }
        private void loadtodgv()
        {
            dataGridView1.DataSource = BUS.xuat_CS();
            comts.DataSource = BUS.xuat_TS();
            comts.DisplayMember = "Tên TS";
            comts.ValueMember = "Mã TS";
            comts.Text = "";

        }
        private void disableInput()
        {
            txtmacs.Enabled = false;
            comts.Enabled = false;
            comtt.Enabled = false;

        }
        private void enableInput()
        {
            txtmacs.Enabled = true;
            comtt.Enabled = true;
            comts.Enabled = true;


        }

        private void clearInput()
        {
            txtmacs.Clear();
            comts.Text = "";
            comtt.Text = "";

        }
        private void loadtotext()
        {
            txtmacs.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            comtt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            comts.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void CuonSach_Load(object sender, EventArgs e)
        {
            loadtodgv();
            disableInput();
            btnSua.Enabled = false;
        }

        private void comts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadtotext();
            disableInput();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Text = "Xóa";
            btnXoa.Active = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();
            label1.Text = "Số Lượng Sách Thêm";
            btnSua.Enabled = false;
            btnXoa.Text = "Hủy";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableInput();
            txtmacs.Enabled = false;
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
                if (BUS.xoa_CS(txtmacs.Text) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadtodgv();
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

                    if (txtmacs.Text == "") throw new Exception();
                    if (BUS.themtdcs(int.Parse(txtmacs.Text), comtt.Text.Trim(), comts.SelectedValue.ToString()) > 0)
                    {

                        loadtodgv();
                        MessageBox.Show("Thêm Thành Công");


                    }
                    else throw new Exception();
                    label1.Text = "Mã Cuốn Sách";
                }
                else if (btnSua.Active)
                {

                    QLThuVien.ValueObject.CuonSach a = new QLThuVien.ValueObject.CuonSach();
                    a.MaCS = txtmacs.Text.Trim();
                    a.TrangThai = comtt.Text.Trim();
                    a.MaTS = comts.SelectedValue.ToString();

                    if (a.MaCS == null || a.MaCS == "") throw new Exception();
                    if (BUS.sua_CS(a) == 1)
                    {
                        loadtodgv();
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
