using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm();
            reservationForm.Show();
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            var adminForm = new ShowroomTestDriveManagement();
            adminForm.Show();
        }
    }
}
