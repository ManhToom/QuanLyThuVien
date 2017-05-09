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
    public partial class TuaSach : UserControl
    {
        public TuaSach()
        {
            InitializeComponent();
        }

        private void updateDataToDgv()
        {
            DataTable dt = new DataTable();
            dt = BUS.xuat_TS();
            dgvTuaSach.DataSource = dt;
        }

        private void disbleInput()
        {
            txtMTS.Enabled = false;
            txtTS.Enabled = false;
            txtNamXB.Enabled = false;
            txtGia.Enabled = false;
            txtVT.Enabled = false;
            txtNN.Enabled = false;
            cbbNXB.Enabled = false;
            txtTG.Enabled = false;
            txtNDTT.Enabled = false;
            txtTL.Enabled = false;
        }

        private void enableInput()
        {
            txtMTS.Enabled = true;
            txtTS.Enabled = true;
            txtNamXB.Enabled = true;
            txtGia.Enabled = true;
            txtVT.Enabled = true;
            txtNN.Enabled = true;
            cbbNXB.Enabled = true;
            txtTG.Enabled = true;
            txtNDTT.Enabled = true;
            txtTL.Enabled = true;
        }

        private void clearInput()
        {
            txtMTS.Clear();
            txtTS.Clear();
            txtNamXB.Clear();
            txtGia.Clear();
            txtVT.Clear();
            txtNN.Clear();
            cbbNXB.Items.Clear();
            cbbNXB.Text = null;
            txtTL.Clear();
            txtTG.Clear();
            txtNDTT.Clear();
        }

        DataTable dtNXB = new DataTable();
        private void addItemToCbbNXB()
        {
            cbbNXB.Items.Clear();
            foreach (DataRow row in dtNXB.Rows)
            {
                cbbNXB.Items.Add(row.ItemArray[1].ToString());
            }
            if (cbbNXB.Items.Count > 0)
                cbbNXB.SelectedItem = cbbNXB.Items[0];
        }

        private string maTGcu;
        private void getTGcuaTS()
        {
            maTGcu = null;
            txtTG.Text = null;
            DataTable dtTGcuaTS = BUS.xuat_TGcuaTS(txtMTS.Text);
            foreach (DataRow row in dtTGcuaTS.Rows)
            {
                maTGcu += Convert.ToString(row.ItemArray[0]) + ";";
                txtTG.Text += Convert.ToString(row.ItemArray[1]) + ";";
            }
            if (txtTG.Text != null && txtTG.Text != "") txtTG.Text = txtTG.Text.Remove(txtTG.Text.Length - 1);
            if (maTGcu != null) maTGcu = maTGcu.Remove(maTGcu.Length - 1);
            dtTGcuaTS.Clear();
            dtTGcuaTS.Dispose();
        }

        private string maTLcu;
        private void getTLcuaTS()
        {
            maTLcu = null;
            txtTL.Text = null;
            DataTable dtTLcuaTS = BUS.xuat_TLcuaTS(txtMTS.Text);
            foreach (DataRow row in dtTLcuaTS.Rows)
            {
                maTLcu += Convert.ToString(row.ItemArray[0]) + ";";
                txtTL.Text += Convert.ToString(row.ItemArray[1]) + ";";
            }
            if (txtTL.Text != null && txtTL.Text != "") txtTL.Text = txtTL.Text.Remove(txtTL.Text.Length - 1);
            if (maTLcu != null) maTLcu = maTLcu.Remove(maTLcu.Length - 1);
            dtTLcuaTS.Clear();
            dtTLcuaTS.Dispose();
        }

        private void TuaSach_Load(object sender, EventArgs e)
        {
            disbleInput();
            updateDataToDgv();
            btnSua.Enabled = false;
            dtNXB = BUS.xuat_NXB();
        }

        private void loadDataToTxt()
        {
            txtMTS.Text = dgvTuaSach.CurrentRow.Cells[0].Value.ToString();
            txtTS.Text = dgvTuaSach.CurrentRow.Cells[1].Value.ToString();
            txtNamXB.Text = dgvTuaSach.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dgvTuaSach.CurrentRow.Cells[3].Value.ToString();
            txtVT.Text = dgvTuaSach.CurrentRow.Cells[4].Value.ToString();
            txtNDTT.Text = dgvTuaSach.CurrentRow.Cells[5].Value.ToString();
            txtNN.Text = dgvTuaSach.CurrentRow.Cells[6].Value.ToString();
            foreach (DataRow row in dtNXB.Rows)
            {
                if (row.ItemArray[0].ToString() == dgvTuaSach.CurrentRow.Cells[7].Value.ToString())
                {
                    cbbNXB.Text = row.ItemArray[1].ToString();
                    break;
                }
            }
            getTGcuaTS();
            ChonTG.maTG = null;

            getTLcuaTS();
            ChonTL.maTL = null;
        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            if (btnSua.Active && ChonTG.maTG == null)
                ChonTG.maTG = maTGcu;
            Form frmTG = new Tab.ChonTG();
            frmTG.ShowDialog();
            if (ChonTG.maTG != null && ChonTG.tenTG == null) return;
            else
                txtTG.Text = ChonTG.tenTG;
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            if (btnSua.Active && ChonTL.maTL == null)
                ChonTL.maTL = maTLcu;
            Form frmTL = new Tab.ChonTL();
            frmTL.ShowDialog();
            if (ChonTL.maTL != null && ChonTL.tenTL == null) return;
            else
                txtTL.Text = ChonTL.tenTL;
        }

        private void dgvTuaSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disbleInput();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Active = true;
            btnXoa.Text = "Xóa";
            loadDataToTxt();
            ChonTG.maTG = maTGcu;
            ChonTL.maTL = maTLcu;
        }

        //Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();
            addItemToCbbNXB();
            btnSua.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        //Sua
        private void btnSua_Click(object sender, EventArgs e)
        {
			addItemToCbbNXB();
            enableInput();
            txtMTS.Enabled = false;
            btnXoa.Text = "Hủy";
            btnThem.Enabled = false;
           
        }

        //Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Active || btnSua.Active)
            {
                clearInput();
                disbleInput();
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
                if (txtMTS.Text != null)
                {
                    if (BUS.xoa_TS(txtMTS.Text) > 0)
                    {
                        updateDataToDgv();
                        MessageBox.Show("Xóa thành công");
                    }
                    else MessageBox.Show("Không xóa được");
                }
                else MessageBox.Show("Không xóa được");
                clearInput();
                disbleInput();
            }
        }

        //Xac nhan
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //khoi tao TS
                QLThuVien.ValueObject.TuaSach ts = new QLThuVien.ValueObject.TuaSach();
                ts.MaTS = txtMTS.Text.Trim();
                ts.TenTS = txtTS.Text.Trim();
                ts.NamXB = int.Parse(txtNamXB.Text);
                ts.ViTri = txtVT.Text.Trim();
                ts.NoiDungTT = txtNDTT.Text.Trim();
                ts.NnChinh = txtNN.Text.Trim();
                ts.MaNXB = null;
                foreach (DataRow row in dtNXB.Rows)
                {
                    if (cbbNXB.Text == Convert.ToString(row.ItemArray[1]))
                    {
                        ts.MaNXB = Convert.ToString(row.ItemArray[0]);
                        break;
                    }
                }

                if (btnThem.Active)
                {
					ts.Gia1 = int.Parse(txtGia.Text);
                    //them TS
                    if (ts.MaNXB == null || ts.MaTS == "") throw new Exception();

                    if (BUS.them_TS(ts) > 0)
                    {
                        updateDataToDgv();
                    }
                    else throw new Exception();

                    //them TL_TS
                    if (ChonTL.maTL != null)
                    {
                        string[] strTL = ChonTL.maTL.Split(';');
                        QLThuVien.ValueObject.TS_TL tstl = new QLThuVien.ValueObject.TS_TL();
                        tstl.MaTS = ts.MaTS;
                        foreach (string str in strTL)
                        {
                            tstl.MaTL = str;
                            BUS.them_TSTL(tstl);
                        }
                    }

                    //them Viet
                    if (ChonTG.maTG != null)
                    {
                        string[] strTG = ChonTG.maTG.Split(';');
                        QLThuVien.ValueObject.Viet viet = new QLThuVien.ValueObject.Viet();
                        viet.MaTS = ts.MaTS;
                        foreach (string str in strTG)
                        {
                            viet.MaTG = str;
                            BUS.them_V(viet);
                        }
                    }

                    MessageBox.Show("Thêm thành công");
                }
                else if (btnSua.Active)
                {
					ts.Gia1 = int.Parse(txtGia.Text.Split('.')[0]);
                    //sua TS
                    if (ts.MaNXB == null || ts.MaTS == "") throw new Exception();

                    if (BUS.sua_TS(ts) > 0)
                    {
                        updateDataToDgv();
                    }
                    else throw new Exception();

                    //sua TLTS
                    if (ChonTL.maTL != null)
                    {
                        string[] strTL = ChonTL.maTL.Split(';');
                        QLThuVien.ValueObject.TS_TL tstl = new QLThuVien.ValueObject.TS_TL();
                        tstl.MaTS = ts.MaTS;
                        foreach (string str in strTL)
                        {
                            if (str != "")
                                if (maTLcu == null || !maTLcu.Contains(str))
                                {
                                    tstl.MaTL = str;
                                    BUS.them_TSTL(tstl);
                                }
                        }
                    }
                    if (maTLcu != null)
                    {
                        string[] strTL = maTLcu.Split(';');
                        foreach (string str in strTL)
                        {
                            if (str != "")
                                if (ChonTL.maTL == null || !ChonTL.maTL.Contains(str))
                                {
                                    BUS.xoa_TSTL(ts.MaTS, str);
                                }
                        }
                    }

                    //sua viet
                    if (ChonTG.maTG != null)
                    {
                        string[] strTG = ChonTG.maTG.Split(';');
                        QLThuVien.ValueObject.Viet viet = new QLThuVien.ValueObject.Viet();
                        viet.MaTS = ts.MaTS;
                        foreach (string str in strTG)
                        {
                            if (str != "")
                                if (maTGcu == null || !maTGcu.Contains(str))
                                {
                                    viet.MaTG = str;
                                    BUS.them_V(viet);
                                }
                        }
                    }
                    if (maTGcu != null)
                    {
                        string[] strTG = maTGcu.Split(';');
                        foreach (string str in strTG)
                        {
                            if (str != "")
                                if (ChonTG.maTG == null || !ChonTG.maTG.Contains(str))
                                {
                                    BUS.xoa_V(ts.MaTS, str);
                                }
                        }
                    }
                    MessageBox.Show("Sửa thành công");
                }
                
            }
            catch
            {
                MessageBox.Show("Input sai");
            }
            finally
            {
                clearInput();
                disbleInput();
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Text = "Xóa";
            }
        }
    }
}
