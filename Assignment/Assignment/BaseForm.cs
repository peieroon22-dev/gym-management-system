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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btn_receptionist_Click(object sender, EventArgs e)
        {
            Manager_receptionist mangerRegistrationist = new Manager_receptionist();
            mangerRegistrationist.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Manager_profile managerProfile = new Manager_profile();
            managerProfile.Show();
            this.Close();
        }
        private void btn_trainer_Click(object sender, EventArgs e)
        {
            Manager_trainer managerTrainer = new Manager_trainer();
            managerTrainer.Show();
            this.Close();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
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

        private void BaseForm_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            Manager_member manager_Member = new Manager_member();
            manager_Member.Show();
            this.Close();
        }

        private void btn_trainSession_Click(object sender, EventArgs e)
        {
            Manager_training_session manager_Training_Session = new Manager_training_session();
            manager_Training_Session.Show();
            this.Close();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Manager_product manager_Product = new Manager_product();
            manager_Product.Show();
            this.Close();
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            Manager_appointment manager_Appointment = new Manager_appointment();
            manager_Appointment.Show();
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
                // 关闭提示框，不执行其他操作
            }
        }

    }
}
