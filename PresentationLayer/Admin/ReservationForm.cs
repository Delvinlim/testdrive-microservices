using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataModelLayer;

namespace PresentationLayer
{
    public partial class ReservationForm : Form
    {
        List<VehiclesClass> Vehicles_List;
        VehiclesClass Vehicle;
        public ReservationForm()
        {
            InitializeComponent();
            Vehicles_List = VehiclesBLL.GetVehicles();
            if (Vehicles_List != null)
            {
                foreach (var vehicle in Vehicles_List)
                {
                    comboBox_Vehicles.Items.Add($"{vehicle.Id} - {vehicle.Name}");
                }
            }
            else
            {
                MessageBox.Show("No Vehicles");
            }
        }
        VehiclesBLL VehiclesBLL = new VehiclesBLL();

        private bool IsEmpty(Control control)
        {
            foreach (TextBox tb in control.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim().Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = comboBox_Vehicles.SelectedItem.ToString().Split('-')[0];
                VehiclesBLL VehiclesBLL = new VehiclesBLL();
                VehiclesBLL vehiclesBLL = VehiclesBLL;
                Vehicle = vehiclesBLL.GetVehicle(selectedValue);
                CustomersClass Customer = new CustomersClass
                {
                    Name = txtBox_Name.Text,
                    Email = txtBox_Email.Text,
                    Phone = txtBox_Phone.Text,
                    VehicleId = int.Parse(comboBox_Vehicles.SelectedItem.ToString().Split('-')[0]),
                    Vehicle = Vehicle,
                };

                //Buat business layer baru
                CustomersBLL customersBLL = new CustomersBLL();
                customersBLL.InsertCustomer(Customer);
                MessageBox.Show("Successfully Booked, Admin will email you soon");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void bindVehicles(List<VehiclesClass> vehicles)
        {
            comboBox_Vehicles.DataSource = vehicles;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            VehiclesBLL VehiclesBLL = new VehiclesBLL();
            Vehicles_List = VehiclesBLL.GetVehicles();
            //bindVehicles(Vehicles_List);
        }

        private void groupBox_Employee_Enter(object sender, EventArgs e)
        {
                
        }

        // Vehicle
        private void comboBox_Vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
