using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
        }

        private void ckcShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcShow.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtuser.Text == "") || (txtpass.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TM8LAAJ\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True");
                con.Open();
                string s = "select count(*) from account where acc='" + txtuser.Text + "'and pass='" + txtpass.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    FormMain a = new FormMain();
                    a.Show();
                    con.Close();
                }
                else
                {
                    // MessageBox.Show("loi");
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
