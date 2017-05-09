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
    public partial class LapPhieuMuon : UserControl
    {
        public static string maDG = null;
        public LapPhieuMuon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = (Form)(this.Parent as Form);
            if (frm != null) frm.Close();
        }

        private void btnNextClick()
        {
            try
            {
                QLThuVien.ValueObject.PhieuMuonTra PMT = new QLThuVien.ValueObject.PhieuMuonTra();
                PMT.SoPMT = txtSoPMT.Text.Trim();
                PMT.MaDG = txtMDG.Text.Trim();
                PMT.MaTT = txtMTT.Text.Trim();
                PMT.NgayLap = dateLap.Value;
                PMT.NgayHTra = dateHtra.Value;
                PMT.NgayTra = dateLap.Value;
                if (DateTime.Compare(dateLap.Value, dateHtra.Value) >= 0) throw new Exception();
                if (QLThuVien.BUSLayer.BUS.them_PMT(PMT) == 1)
                {
                    Form frm = (Form)(this.Parent as Form);
                    frm.Controls.Clear();
                    ThemSachMuon.soPMT = txtSoPMT.Text.Trim();
                    frm.Controls.Add(new ThemSachMuon());
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                labErr.Text = "Input sai";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNextClick();
        }

        private void txtSoPMT_TextChanged(object sender, EventArgs e)
        {
            labErr.Text = "";
        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            dateLap.Value = DateTime.Today;
            dateHtra.Value = dateLap.Value.AddDays(10);
            txtMDG.Text = maDG;
            txtSoPMT.Enabled = true;
            //txtSoPMT.Text = QLThuVien.BUSLayer.BUS.xuat_SoPMTnew();
        }

        private void txtMTT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnNextClick();
            }
        }
    }
}
