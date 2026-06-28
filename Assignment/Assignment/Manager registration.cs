using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouveForm;

namespace Assignment
{
    public partial class Manager_registration : Form
    {
        public Manager_registration()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_restore.Location = btn_max.Location;
            btn_restore.Visible = true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_userName.Text = txt_password.Text = txt_phoneNumber.Text = txt_email.Text = txt_home.Text = "";
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }
    }
}
