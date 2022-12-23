
namespace PresentationLayer
{
    partial class ucAdminReservation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Reservation = new System.Windows.Forms.GroupBox();
            this.dgv_Reservations = new System.Windows.Forms.DataGridView();
            this.btn_updateReservation = new System.Windows.Forms.Button();
            this.groupBox_Reservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Reservation
            // 
            this.groupBox_Reservation.Controls.Add(this.btn_updateReservation);
            this.groupBox_Reservation.Controls.Add(this.dgv_Reservations);
            this.groupBox_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Reservation.Location = new System.Drawing.Point(30, 30);
            this.groupBox_Reservation.Name = "groupBox_Reservation";
            this.groupBox_Reservation.Size = new System.Drawing.Size(826, 537);
            this.groupBox_Reservation.TabIndex = 4;
            this.groupBox_Reservation.TabStop = false;
            this.groupBox_Reservation.Text = "Reservation List";
            // 
            // dgv_Reservations
            // 
            this.dgv_Reservations.AllowUserToAddRows = false;
            this.dgv_Reservations.AllowUserToDeleteRows = false;
            this.dgv_Reservations.AllowUserToOrderColumns = true;
            this.dgv_Reservations.AllowUserToResizeColumns = false;
            this.dgv_Reservations.AllowUserToResizeRows = false;
            this.dgv_Reservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservations.Location = new System.Drawing.Point(6, 85);
            this.dgv_Reservations.MultiSelect = false;
            this.dgv_Reservations.Name = "dgv_Reservations";
            this.dgv_Reservations.ReadOnly = true;
            this.dgv_Reservations.RowHeadersWidth = 51;
            this.dgv_Reservations.RowTemplate.Height = 24;
            this.dgv_Reservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Reservations.Size = new System.Drawing.Size(814, 446);
            this.dgv_Reservations.TabIndex = 0;
            // 
            // btn_updateReservation
            // 
            this.btn_updateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateReservation.Location = new System.Drawing.Point(6, 44);
            this.btn_updateReservation.Name = "btn_updateReservation";
            this.btn_updateReservation.Size = new System.Drawing.Size(165, 35);
            this.btn_updateReservation.TabIndex = 2;
            this.btn_updateReservation.Text = "Send Confirmation Email";
            this.btn_updateReservation.UseVisualStyleBackColor = true;
            this.btn_updateReservation.Click += new System.EventHandler(this.btn_updateReservation_Click);
            // 
            // ucAdminReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Reservation);
            this.Name = "ucAdminReservation";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(886, 597);
            this.Load += new System.EventHandler(this.ucReservation_Load);
            this.groupBox_Reservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Reservation;
        private System.Windows.Forms.DataGridView dgv_Reservations;
        private System.Windows.Forms.Button btn_updateReservation;
    }
}
