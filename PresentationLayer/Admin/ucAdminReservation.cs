using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataModelLayer;

namespace PresentationLayer
{
    public partial class ucAdminReservation : UserControl
    {
        public ucAdminReservation()
        {
            InitializeComponent();
        }

        private void btn_updateReservation_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show("Send Confirmation Email?", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_Reservations.SelectedCells[0].Value.ToString());

                    ReservationBLL ReservationBLL = new ReservationBLL();
                    ReservationBLL.UpdateReservation(id);

                    bind_DGV(ReservationBLL.GetReservations());

                    MessageBox.Show("Email sent successfully!");

                    resetTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void ucReservation_Load(object sender, EventArgs e)
        {
            List<ReservationsClass> Reservation_List;
            try
            {
                ReservationBLL ReservationBLL = new ReservationBLL();
                Reservation_List = ReservationBLL.GetReservations();
                bind_DGV(Reservation_List);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void bind_DGV(List<ReservationsClass> reservations)
        {
            dgv_Reservations.DataSource = reservations;
            dgv_Reservations.Columns[5].Visible = false;
            //dgv_Reservations.Columns[1].Visible = false;
            //dgv_Reservations.Columns[3].Visible = false;
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

    }
}
