using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Manager_profile : BaseForm
    {
        public Manager_profile()
        {
            InitializeComponent();
        }
 

        private void Manager_profile_Load(object sender, EventArgs e)
        {

        }

        private void btn_jumpRE_Click(object sender, EventArgs e)
        {
            Manager_receptionist mangerRegistrationist = new Manager_receptionist();
            mangerRegistrationist.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_trainer managerTrainer = new Manager_trainer();
            managerTrainer.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_member manager_Member = new Manager_member();
            manager_Member.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager_training_session manager_Training_Session = new Manager_training_session();
            manager_Training_Session.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_product manager_Product = new Manager_product();
            manager_Product.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_appointment manager_Appointment = new Manager_appointment();
            manager_Appointment.Show();
            this.Close();
        }
    }
}
