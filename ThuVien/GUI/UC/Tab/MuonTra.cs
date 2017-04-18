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
    public partial class MuonTra : UserControl
    {
        public MuonTra()
        {
            InitializeComponent();
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

        private void loadPMT()
        {
            dgvPMT.DataSource = BUS.xuat_PMTcuaDG(txtMDG1.Text.Trim());
        }

        private void loadCTM()
        {
            dgvCTM.DataSource = BUS.xuat_CTMcuaPM(txtSoPMT.Text.Trim());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDG();
            loadPMT();
        }

        private void MuonTra_Resize(object sender, EventArgs e)
        {
            grbPM.Width = this.Width / 2;
            grbDG.Width = this.Width / 2;
        }

        private void txtMDG1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loadDG();
                loadPMT();
            }
        }

        private void disablePMT()
        {
            txtSoPMT.Enabled = false;
            txtMDG2.Enabled = false;
            txtMTT.Enabled = false;
            dateHtra.Enabled = false;
            dateLap.Enabled = false;
            dateTra.Enabled = false;
        }

        private void enablePMT()
        {
            dateHtra.Enabled = true;
            dateLap.Enabled = true;
            dateTra.Enabled = true;
        }

        private void loadTxtPMT()
        {
            txtSoPMT.Text = dgvPMT.CurrentRow.Cells[0].Value.ToString().Trim();
            dateLap.Value = Convert.ToDateTime(dgvPMT.CurrentRow.Cells[1].Value);
            dateHtra.Value = Convert.ToDateTime(dgvPMT.CurrentRow.Cells[2].Value);
            try
            {
                dateTra.Value = Convert.ToDateTime(dgvPMT.CurrentRow.Cells[3].Value);
                dateTra.Format = DateTimePickerFormat.Short;
            }
            catch
            {
                dateTra.Value = dateLap.Value;
                dateTra.Format = DateTimePickerFormat.Custom;
            }
            txtMDG2.Text = dgvPMT.CurrentRow.Cells[4].Value.ToString().Trim();
            txtMTT.Text = dgvPMT.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void dgvPMT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Active = true;
            disablePMT();
            loadTxtPMT();
            loadCTM();
        }

        private void MuonTra_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            disablePMT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Text = "H?y";
            enablePMT();
        }

        private void clearDG()
        {
            txtTenDG.Clear();
            txtNgaySinh.Clear();
            txtSDT.Clear();
            rdbNam.Checked = true;
            txtLoai.Clear();
        }

        private void clearPMT()
        {
            dgvPMT.DataSource = null;
        }

        private void clearCTM()
        {
            dgvCTM.DataSource = null;
        }

        private void clearTxtPMT()
        {
            txtSoPMT.Clear();
            txtMDG2.Clear();
            txtMTT.Clear();
            dateLap.Format = DateTimePickerFormat.Short;
            dateHtra.Format = DateTimePickerFormat.Short;
            dateTra.Format = DateTimePickerFormat.Short;
        }

        private void txtMDG1_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDG.Text.Trim() != "")
            {
                clearDG();
                clearCTM();
                clearTxtPMT();
                clearPMT();
            }
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSua.Active)
                {
                    QLThuVien.ValueObject.PhieuMuonTra PMT = new QLThuVien.ValueObject.PhieuMuonTra();
                    PMT.SoPMT = txtSoPMT.Text.Trim();
                    PMT.MaDG = txtMDG2.Text.Trim();
                    PMT.MaTT = txtMTT.Text.Trim();
                    PMT.NgayLap = dateLap.Value;
                    PMT.NgayHTra = dateHtra.Value;
                    PMT.NgayTra = dateTra.Value;

                    if (DateTime.Compare(PMT.NgayLap, PMT.NgayHTra) >= 0) throw new Exception();
                    if (DateTime.Compare(PMT.NgayLap, PMT.NgayTra) > 0) throw new Exception();

                    if (BUS.sua_PMT(PMT) == 1)
                    {
                        BUS.tinhTien_PMT(PMT.SoPMT);
                        clearCTM();
                        loadPMT();
                        MessageBox.Show("S?a thành công");
                    }
                    else throw new Exception();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Input sai");
            }
            finally
            {
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                clearTxtPMT();
                disablePMT();
                btnSua.Enabled = false;
            }
        }

        private void dateTra_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateLap.Value, dateTra.Value) == 0)
                dateTra.Format = DateTimePickerFormat.Custom;
            else
                dateTra.Format = DateTimePickerFormat.Short;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnSua.Active)
            {
                clearTxtPMT();
                disablePMT();
                btnXoa.Active = true;
                btnXoa.Text = "Xóa";
                btnSua.Enabled = false;
            }
            else
            {
                if (BUS.xoa_PMT(txtSoPMT.Text.Trim()) > 0)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không xóa du?c");
                clearCTM();
                clearTxtPMT();
                disablePMT();
                loadPMT();
                btnSua.Enabled = false;
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTra.Text == " ")
                {
                    QLThuVien.ValueObject.PhieuMuonTra PMT = new QLThuVien.ValueObject.PhieuMuonTra();
                    PMT.SoPMT = txtSoPMT.Text.Trim();
                    PMT.MaDG = txtMDG2.Text.Trim();
                    PMT.MaTT = txtMTT.Text.Trim();
                    PMT.NgayLap = dateLap.Value;
                    PMT.NgayHTra = dateHtra.Value;
                    PMT.NgayTra = DateTime.Today;

                    if (DateTime.Compare(PMT.NgayLap, PMT.NgayTra) == 0) throw new Exception();

                    if (BUS.sua_PMT(PMT) == 1)
                    {
                        BUS.tinhTien_PMT(PMT.SoPMT);
                        loadPMT();
                        loadCTM();
                        MessageBox.Show("Tr? thành công");
                        ChiTietMuon.soPMT = PMT.SoPMT;
                        ChiTietMuon.maDG = PMT.MaDG;
                        ChiTietMuon.ngayLap = PMT.NgayLap.ToShortDateString();
                        ChiTietMuon.ngayHtra = PMT.NgayHTra.ToShortDateString();
                        ChiTietMuon.ngayTra = (DateTime.Compare(PMT.NgayLap, PMT.NgayTra) != 0) ? PMT.NgayTra.ToShortDateString() : "";
                        new ChiTietMuon().Show();
                    }
                    else throw new Exception();
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tr? du?c");
            }
        }

        private void dgvPMT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvPMT.CurrentCell = (sender as DataGridView)[0, dgvPMT.HitTest(e.X, e.Y).RowIndex];
                    btnSua.Enabled = true;
                    btnXoa.Active = true;
                    disablePMT();
                    loadTxtPMT();
                    loadCTM();
                    cmsPMT.Show(dgvPMT, e.X, e.Y);
                }
                catch (Exception)
                {

                }
            }
        }

        private void dgvCTM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvCTM.CurrentCell = (sender as DataGridView)[0, dgvCTM.HitTest(e.X, e.Y).RowIndex];
                    cmsCTM.Show(dgvCTM, e.X, e.Y);
                }
                catch (Exception)
                {

                }
            }
        }

        private void tlmXemPhieu_Click(object sender, EventArgs e)
        {
            ChiTietMuon.soPMT = txtSoPMT.Text.Trim();
            ChiTietMuon.maDG = txtMDG2.Text.Trim();
            ChiTietMuon.ngayLap = dateLap.Value.ToShortDateString();
            ChiTietMuon.ngayHtra = dateHtra.Value.ToShortDateString();
            ChiTietMuon.ngayTra = (DateTime.Compare(dateLap.Value, dateTra.Value) != 0) ? dateTra.Value.ToShortDateString() : "";
            new ChiTietMuon().Show();
        }

        private void tlmHong_Click(object sender, EventArgs e)
        {
            if (BUS.sua_TrangThaiCS(dgvCTM.CurrentRow.Cells[0].Value.ToString().Trim(), "Hỏng") == 1)
                MessageBox.Show("S?a thành công");
            else
                MessageBox.Show("Không s?a du?c");
        }

        private void tlmMat_Click(object sender, EventArgs e)
        {
            if (BUS.sua_TrangThaiCS(dgvCTM.CurrentRow.Cells[0].Value.ToString().Trim(), "Mất") == 1)
                MessageBox.Show("S?a thành công");
            else
                MessageBox.Show("Không s?a du?c");
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (txtMDG1.Text.Trim() != "" )
            {
                LapPhieuMuon.maDG = txtMDG1.Text;
                new MuonSach().ShowDialog();
                clearCTM();
                clearTxtPMT();
                disablePMT();
                loadPMT();
                btnSua.Enabled = false;
            }
            else
                MessageBox.Show("Mă d?c gi? sai ho?c d?c gi? không du?c mu?n sách");
        }

        private void dateLap_ValueChanged(object sender, EventArgs e)
        {
            if (dateTra.Text == " ")
                dateTra.Value = dateLap.Value;
        }

        
    }
}
