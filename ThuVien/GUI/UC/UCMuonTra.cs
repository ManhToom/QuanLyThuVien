using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class UCMuonTra : UserControl
    {
        public UCMuonTra()
        {
            InitializeComponent();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            Tab.MuonTra tabMT = new Tab.MuonTra();
            tabMT.Dock = DockStyle.Fill;
            pnlUseMuonTra.Controls.Add(tabMT);
            foreach (Control ctrl in pnlUseMuonTra.Controls)
            {
                if (ctrl != tabMT)
                    ctrl.Dispose();
            }
        }

        private void flat_Button1_Click(object sender, EventArgs e)
        {
            Tab.CuonSach a = new Tab.CuonSach();
            a.Dock = DockStyle.Fill;
            pnlUseMuonTra.Controls.Add(a);
            foreach (Control ctrl in pnlUseMuonTra.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }
		private void loadDG()
        {
            DataTable dt = BUS.xuat_DGcoMa(txtMDG1.Text.Trim());
            if (dt.Rows.Count == 1)
            {
                txtTenDG.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                if (Convert.ToString(dt.Rows[0].ItemArray[2]) == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtNgaySinh.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[3]).ToShortDateString();
                txtSDT.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                txtLoai.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
            }
        }

       
    }
}
