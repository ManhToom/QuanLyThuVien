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

namespace GUI.UC
{
    public partial class UCTimKiem : UserControl
    {
        public UCTimKiem()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataTable a = new DataTable();
            DataTable b = new DataTable();
            a = BUS.xuat_TL();
            comtl.DataSource = a;
            comtl.DisplayMember = "Tên TL";
            comtl.ValueMember = "Mã TL";
            b = BUS.xuat_TG();
            comtg.DataSource = b;
            comtg.DisplayMember = "Tên TG";
            comtg.ValueMember = "Mã TG";
            comtg.Text = "";
            comtl.Text = "";
            
        }
        private void loaddgv()
        {
            string i, j;
            if (comtl.Text.Length == 0)
            {
                i = "";
            }
            else
            {
                i = comtl.SelectedValue.ToString();
            }
            if (comtg.Text.Length == 0)
            {
                j = "";
            }
            else
            {
                j = comtg.SelectedValue.ToString();
            }
            dataGridView1.DataSource = BUS.search(txttesach.Text, "", i, j);


        }

        private void UCTimKiem_Load(object sender, EventArgs e)
        {
            load();
        }

        private void flat_Button1_Click(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void UCTimKiem_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void flat_Button1_Click_1(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
