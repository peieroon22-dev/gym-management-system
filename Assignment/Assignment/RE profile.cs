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
    public partial class RE_profile : ReBaseForm
    {
        public RE_profile()
        {
            InitializeComponent();
        }

        private void RE_profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RE_trainer re_trainer = new RE_trainer();
            re_trainer.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RE_member rE_Member = new RE_member();
            rE_Member.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RE_training_session rE_Training_Session = new RE_training_session();
            rE_Training_Session.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RE_product rE_Product = new RE_product();
            rE_Product.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RE_appointment rE_Appointment = new RE_appointment();
            rE_Appointment.Show();
            this.Close();
        }
    }
}
