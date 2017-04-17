using System;
using System.Data;
using System.Windows.Forms;
using QLThuVien.BUSLayer;

namespace GUI.UC.Tab
{
    public partial class ChonTG : Form
    {
        public static string maTG;
        public static string tenTG;
        public ChonTG()
        {
            InitializeComponent();
        }

        private void loadDataToDgv()
        {
            dgvTG.DataSource = BUS.xuat_TG();
            DataGridViewCheckBoxColumn cl = new DataGridViewCheckBoxColumn();
            cl.Name = "check";
            cl.HeaderText = "Check";
            dgvTG.Columns.Insert(0, cl);
            foreach (DataGridViewRow row in dgvTG.Rows)
            {
                if (maTG != null && maTG.Contains(row.Cells[1].Value.ToString()))
                    row.Cells[0].Value = true;
                else
                    row.Cells[0].Value = false;
            }
        }

        private void ChonTG_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
        }

        private void dgvTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTG.CurrentRow.Cells[0].Value = !Convert.ToBoolean(dgvTG.CurrentRow.Cells[0].Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tenTG = null;
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            maTG = null;
            tenTG = null;
            foreach (DataGridViewRow row in dgvTG.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    maTG += row.Cells[1].Value.ToString() + ";";
                    tenTG += row.Cells[2].Value.ToString() + ";";
                }
            }
            if (maTG != null)
                maTG = maTG.Remove(maTG.Length - 1);
            if (tenTG != null)
                tenTG = tenTG.Remove(tenTG.Length - 1);
            this.Dispose();
        }
    }
}
