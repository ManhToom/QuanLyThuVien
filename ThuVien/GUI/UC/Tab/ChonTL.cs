using QLThuVien.BUSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.Tab
{
    public partial class ChonTL : Form
    {
        public static string tenTL;
        public static string maTL;
        public ChonTL()
        {
            InitializeComponent();
        }

        private void loadDataToDgv()
        {
            dgvTL.DataSource = BUS.xuat_TL();
            DataGridViewCheckBoxColumn cl = new DataGridViewCheckBoxColumn();
            cl.Name = "check";
            cl.HeaderText = "Check";
            dgvTL.Columns.Insert(0, cl);
            foreach (DataGridViewRow row in dgvTL.Rows)
            {
                if (maTL != null && maTL.Contains(row.Cells[1].Value.ToString()))
                    row.Cells[0].Value = true;
                else
                    row.Cells[0].Value = false;
            }
        }

        private void ChonTL_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTL.CurrentRow.Cells[0].Value = !Convert.ToBoolean(dgvTL.CurrentRow.Cells[0].Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tenTL = null;
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            maTL = null;
            tenTL = null;
            foreach (DataGridViewRow row in dgvTL.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    maTL += row.Cells[1].Value.ToString() + ";";
                    tenTL += row.Cells[2].Value.ToString() + ";";
                }
            }
            if (maTL != null)
                maTL = maTL.Remove(maTL.Length - 1);
            if (tenTL != null)
                tenTL = tenTL.Remove(tenTL.Length - 1);
            this.Dispose();
        }
    }
}
