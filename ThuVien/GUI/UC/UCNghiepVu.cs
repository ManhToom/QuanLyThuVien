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
    public partial class UCNghiepVu: UserControl
    {
        public UCNghiepVu()
        {
            InitializeComponent();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            Tab.DocGia tabDG = new Tab.DocGia();
            tabDG.Dock = DockStyle.Fill;
            pnlUseNghiepVu.Controls.Add(tabDG);
            foreach (Control ctrl in pnlUseNghiepVu.Controls)
            {
                if (ctrl != tabDG)
                    ctrl.Dispose();
            }
        }
    }
}
