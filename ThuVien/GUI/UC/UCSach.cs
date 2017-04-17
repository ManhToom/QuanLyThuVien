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
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        private void btnTuaSach_Click(object sender, EventArgs e)
        {
            Tab.TuaSach tabTs = new Tab.TuaSach();
            tabTs.Dock = DockStyle.Fill;
            pnlUseSach.Controls.Add(tabTs);
            foreach (Control ctrl in pnlUseSach.Controls)
            {
                if (ctrl != tabTs)
                    ctrl.Dispose();
            }
        }
    }
}
