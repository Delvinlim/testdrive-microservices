using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataModelLayer;
using presentationTier.Admin;

namespace PresentationLayer
{
    public partial class ucAdminVehicle : UserControl
    {
        public ucAdminVehicle()
        {
            InitializeComponent();
        }

        private void ucAdminVehicle_Load(object sender, EventArgs e)
        {
            List<VehiclesClass> Vehicles_List;
            try
            {
                VehiclesBLL VehiclesBLL = new VehiclesBLL();
                Vehicles_List = VehiclesBLL.GetVehicles();
                bind_DGV(Vehicles_List);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void bind_DGV(List<VehiclesClass> vehicles)
        {
            dgv_Vehicles.DataSource = vehicles;
        }

        private void btn_deleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show("Delete this vehicle?", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    string id = dgv_Vehicles.SelectedCells[0].Value.ToString();

                    VehiclesBLL VehiclesBLL = new VehiclesBLL();
                    VehiclesBLL.DeleteVehicle(int.Parse(id));

                    bind_DGV(VehiclesBLL.GetVehicles());

                    MessageBox.Show("Delete success!");

                    resetTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void resetTextbox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) => {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                }
            };

            func(Controls);
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var VehicleForm = new VehiclesForm();
                VehicleForm.Show();
            } catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void dgv_Vehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
