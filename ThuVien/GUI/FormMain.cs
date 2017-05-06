using GUI.ComponentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI
{
    public partial class FormMain : Form
    {
        private ResizeAndMove RsMv;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RsMv = new ResizeAndMove(this, new Control[] { pnlMenu, ptrHome }, false);
            bxForm.FormMain = this;
        }

        private bool zoom = true;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (zoom)
            {
                bxForm.Location = new Point(13, 2);
                bxForm.BoxStyle = BoxFrom.BxStyle.Column;
                pnlMenu.Width = 43;
                zoom = false;
            }
            else
            {
                bxForm.Location = new Point(13, 2);
                pnlMenu.Width = 199;
                bxForm.BoxStyle = BoxFrom.BxStyle.Row;
                zoom = true;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            UC.UCSach ucSach = new UC.UCSach();
            ucSach.Dock = DockStyle.Fill;
            pnlUse.Controls.Add(ucSach);
            foreach (Control ctrl in pnlUse.Controls)
            {
                if (ctrl != ucSach)
                    ctrl.Dispose();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            UC.UCTimKiem a = new UC.UCTimKiem();
            a.Dock = DockStyle.Fill;
            pnlUse.Controls.Add(a);
            foreach (Control ctrl in pnlUse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            UC.UCMuonTra ucMuonTra = new UC.UCMuonTra();
            ucMuonTra.Dock = DockStyle.Fill;
            pnlUse.Controls.Add(ucMuonTra);
            foreach (Control ctrl in pnlUse.Controls)
            {
                if (ctrl != ucMuonTra)
                    ctrl.Dispose();
            }
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            UC.UCNghiepVu ucMuonTra = new UC.UCNghiepVu();
            ucMuonTra.Dock = DockStyle.Fill;
            pnlUse.Controls.Add(ucMuonTra);
            foreach (Control ctrl in pnlUse.Controls)
            {
                if (ctrl != ucMuonTra)
                    ctrl.Dispose();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            UC.UCThongKe a = new UC.UCThongKe();
            a.Dock = DockStyle.Fill;
            pnlUse.Controls.Add(a);
            foreach (Control ctrl in pnlUse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://quanlytv.comeze.com/");
        }
    }
}
