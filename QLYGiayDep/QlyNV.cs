using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYGiayDep
{
    public partial class QlyNV : Form
    {
        public QlyNV()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        Connect kn=new Connect();
        public void getData()
        {
            string query = "select* from nhanvien";
            DataTable dt=kn.laydulieu(query);
            dgvnv.DataSource = dt;
        }
        public void ClearText()
        {
            txthoten.Text = "";
            txtid.Text = "";
            txtsdt.Text = "";
            txtdc.Text = "";
            txtdate.Text = "";
            txtchucvu.Text = "";
            txttimkiem.Text = "";
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            
            Close();
                
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query=string.Format("delete nhanvien where idnv='{0}'",txtid.Text);
            bool r = kn.thucthi(query);
            if(r)
            {
                MessageBox.Show("Xóa thành công");
                btnlammoi.PerformClick();
            }
            else {
                MessageBox.Show("Xóa thất bại");
            }

            
        }

        private void QlyNV_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            getData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NhanVien values('{0}','{1}','{2}','{3}','{4}','{5}')",
               txtid.Text,
               txthoten.Text,
               txtchucvu.Text,
               txtdate.Text,
               txtsdt.Text,
               txtdc.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Thêm thành công");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }



        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if(r>=0)
            {
                txtid.Text = dgvnv.Rows[r].Cells[0].Value.ToString();
                txthoten.Text = dgvnv.Rows[r].Cells[1].Value.ToString();
                txtchucvu.Text = dgvnv.Rows[r].Cells[2].Value.ToString();
                txtdate.Text = dgvnv.Rows[r].Cells[3].Value.ToString();
                txtsdt.Text = dgvnv.Rows[r].Cells[4].Value.ToString();
                txtdc.Text = dgvnv.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update nhanvien set tennv='{1}',chucvu='{2}',ngaysinh='{3}',sdt='{4}',diachi='{5}'where idnv='{0}'",
               txtid.Text,
               txthoten.Text,
               txtchucvu.Text,
               txtdate.Text,
               txtsdt.Text,
               txtdc.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Sửa thành công");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
        
           
    }
}
