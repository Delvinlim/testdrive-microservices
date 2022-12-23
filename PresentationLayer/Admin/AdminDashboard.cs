using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ShowroomTestDriveManagement : Form
    {
        private static ShowroomTestDriveManagement Instance;
        public static ShowroomTestDriveManagement GetInstance 
        {
            get 
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new ShowroomTestDriveManagement();
                }
                Instance.CenterToScreen();

                return Instance;
            }
        }

        public ShowroomTestDriveManagement()
        {
            InitializeComponent();
        }

        private void btn_Vehicle_Click(object sender, EventArgs e)
        {
            contentFlowPanel.Controls.Clear();

            UserControl ucEmployee = new ucAdminVehicle();
            ucEmployee.Location = new Point(0, 0);
            ucEmployee.Dock = DockStyle.Top;
            contentFlowPanel.Controls.Add(ucEmployee);
            ucEmployee.BringToFront();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            contentFlowPanel.Controls.Clear();

            UserControl ucDepartment = new ucAdminReservation();
            ucDepartment.Location = new Point(0, 0);
            ucDepartment.Dock = DockStyle.Top;
            contentFlowPanel.Controls.Add(ucDepartment);
            ucDepartment.BringToFront();
        }

        private void AdminManagementApp_Load(object sender, EventArgs e)
        {
            Vehicles();
        }

        private void Vehicles()
        {
            contentFlowPanel.Controls.Clear();

            UserControl ucVehicles = new ucAdminVehicle();
            ucVehicles.Location = new Point(0, 0);
            ucVehicles.Dock = DockStyle.Top;
            contentFlowPanel.Controls.Add(ucVehicles);
            ucVehicles.BringToFront();
        }

        private void AdminManagementApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contentFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
