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
    public partial class HeThongQL : Form
    {
        public HeThongQL()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private Form currentFormChild;
        private void OpendChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpendChildForm(new QLyHoaDon());
            home.Text = btnhd.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpendChildForm(new QlyNV());
            home.Text = btnhd.Text;
        }

        private void btnncc_Click(object sender, EventArgs e)
        {
            OpendChildForm(new QLyNCC());
            home.Text = btnncc.Text;

        }

        private void btnpn_Click(object sender, EventArgs e)
        {
            OpendChildForm(new QLyPhieuNhap());
            home.Text = btnpn.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpendChildForm(new QlyNV());
            home.Text = btnnv.Text;
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            OpendChildForm(new QlySP());
            home.Text = btnsp.Text;
        }

        private void btnbctk_Click(object sender, EventArgs e)
        {
            OpendChildForm(new BCTK());
            home.Text = btnbctk.Text;
        }

        private void panelbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
