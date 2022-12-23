using BusinessLogicLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationTier.Admin
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
        }

        private void groupBox_Reservation_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                VehiclesClass Vehicle = new VehiclesClass
                {
                    Name = txtBox_Name.Text,
                    Price = int.Parse(txtBox_Price.Text),
                    ImageUrl = txtBox_Image.Text,
                    Displacement = txtBox_Displacement.Text,
                    MaxSpeed = txtBox_Speed.Text,
                    Length = double.Parse(txtBox_Length.Text),
                    Width = double.Parse(txtBox_Width.Text),
                    Height = double.Parse(txtBox_Height.Text),
                };

                //Buat business layer baru
                VehiclesBLL vehiclesBLL = new VehiclesBLL();
                vehiclesBLL.InsertVehicle(Vehicle);
                MessageBox.Show("Vehicle Created");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }
    }
}
