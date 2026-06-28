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
    public partial class ReBaseForm : Form
    {
        public ReBaseForm()
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

        private void ReBaseForm_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            RE_profile reProfile = new RE_profile();
            reProfile.Show();
            this.Close();
        }
        private void btn_trainer_Click(object sender, EventArgs e)
        {
            RE_trainer re_trainer = new RE_trainer();
            re_trainer.Show();
            this.Close();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            RE_member rE_Member = new RE_member();
            rE_Member.Show();
            this.Close();
        }

        private void btn_trainSession_Click(object sender, EventArgs e)
        {
            RE_training_session rE_Training_Session = new RE_training_session();
            rE_Training_Session.Show();
            this.Close();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            RE_product rE_Product = new RE_product();
            rE_Product.Show();
            this.Close();
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            RE_appointment rE_Appointment = new RE_appointment();
            rE_Appointment.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Proceed to Logout?", "Pop-Up Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
        }
    }
}
