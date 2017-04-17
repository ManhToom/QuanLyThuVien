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
    public partial class UCThongKe : UserControl
    {
        public UCThongKe()
        {
            InitializeComponent();
        }

        private void btntkmuon_Click(object sender, EventArgs e)
        {
            Tab.DangMuon a = new Tab.DangMuon();
            a.Dock = DockStyle.Fill;
            paneluse.Controls.Add(a);
            foreach (Control ctrl in paneluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }

        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            Tab.QuaHan a = new Tab.QuaHan();
            a.Dock = DockStyle.Fill;
            paneluse.Controls.Add(a);
            foreach (Control ctrl in paneluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }

        }

        private void flat_Button1_Click(object sender, EventArgs e)
        {
            Tab.SachTheoTuaSach a = new Tab.SachTheoTuaSach();
            a.Dock = DockStyle.Fill;
            paneluse.Controls.Add(a);
            foreach (Control ctrl in paneluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }
    }
}
