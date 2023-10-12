using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYGiayDep
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Connect kn=new Connect();

        private void button1_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format("select*from Tb_Dangnhap where Taikhoan='{0}'and Matkhau='{1}'",
                txttk.Text,
                txtmk.Text);
            DataTable dt = kn.laydulieu(truyvan);
            if (rdql.Checked)
            {
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    HeThongQL frm = new HeThongQL();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            if (rdnv.Checked)
            {
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    HeThongNV frm = new HeThongNV();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!"); 
                }
            }

        }
    }
}
