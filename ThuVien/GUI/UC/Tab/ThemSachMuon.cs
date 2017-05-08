using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.Tab
{
    public partial class ThemSachMuon : UserControl
    {
        public static string soPMT;
        public ThemSachMuon()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            QLThuVien.BUSLayer.BUS.xoa_PMT(soPMT);
            Form frm = (Form)(this.Parent as Form);
            if (frm != null) frm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTienCoc.Enabled) throw new Exception();
                QLThuVien.ValueObject.ChiTietMuon CTM = new QLThuVien.ValueObject.ChiTietMuon();
                CTM.MaCS = txtMCS.Text.Trim();
                CTM.SoPMT = soPMT;
                CTM.TienCoc = int.Parse(txtTienCoc.Text);
                CTM.TienTToan = -1;
                if (QLThuVien.BUSLayer.BUS.them_CTM(CTM) == 1)
                {
                    dgvCTM.DataSource = QLThuVien.BUSLayer.BUS.xuat_CTMcuaPM(soPMT);
                    labErr.Text = "";
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                labErr.Text = "Input sai";
            }
            finally
            {
                txtMCS.Clear();
                txtTienCoc.Clear();
              
            }
        }

        private void txtMCS_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;
            //    txtTenSach.Text = QLThuVien.BUSLayer.BUS.xuat_TenSach(txtMCS.Text);
            //    if (txtTenSach.Text.Trim() == "")
            //        labErr.Text = "Input sai";
            //    else if (!QLThuVien.BUSLayer.BUS.kiemTra_CS(txtMCS.Text.Trim()))
            //        labErr.Text = "Sách đã được mượn hoặc bị hỏng mất";
            //    else
            //    {
            //        labErr.Text = "";
            //        txtTienCoc.Enabled = true;
            //    }
            //    txtTienCoc.Focus();
            //}
            txtTienCoc.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Form frm = (Form)(this.Parent as Form);
            if (frm != null) frm.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvCTM.CurrentRow!=null)
            {
                QLThuVien.BUSLayer.BUS.xoa_CTM(soPMT, dgvCTM.CurrentRow.Cells[0].Value.ToString());
                dgvCTM.DataSource = QLThuVien.BUSLayer.BUS.xuat_CTMcuaPM(soPMT);
            }
        }

        private void ThemSachMuon_Load(object sender, EventArgs e)
        {
            dgvCTM.DataSource = QLThuVien.BUSLayer.BUS.xuat_CTMcuaPM(soPMT);
        }

        private void txtMCS_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            labErr.Text = "";
        }
    }
}
