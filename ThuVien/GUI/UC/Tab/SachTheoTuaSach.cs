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
    public partial class SachTheoTuaSach : UserControl
    {
        public SachTheoTuaSach()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataTable a = new DataTable();
            a = BUS.tksachdangmuon();
            dgv1.DataSource = a;
        }

        private void SachTheoTuaSach_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
