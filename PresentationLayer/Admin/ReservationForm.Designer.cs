
namespace PresentationLayer
{
    partial class ReservationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Reservation = new System.Windows.Forms.GroupBox();
            this.comboBox_Vehicles = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox_Reservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(141, 50);
            this.txtBox_Name.MaxLength = 16;
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Name.TabIndex = 0;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // groupBox_Reservation
            // 
            this.groupBox_Reservation.Controls.Add(this.comboBox_Vehicles);
            this.groupBox_Reservation.Controls.Add(this.btn_Save);
            this.groupBox_Reservation.Controls.Add(this.label8);
            this.groupBox_Reservation.Controls.Add(this.label3);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Phone);
            this.groupBox_Reservation.Controls.Add(this.label2);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Email);
            this.groupBox_Reservation.Controls.Add(this.label1);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Name);
            this.groupBox_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox_Reservation.Location = new System.Drawing.Point(14, 14);
            this.groupBox_Reservation.Name = "groupBox_Reservation";
            this.groupBox_Reservation.Size = new System.Drawing.Size(393, 284);
            this.groupBox_Reservation.TabIndex = 2;
            this.groupBox_Reservation.TabStop = false;
            this.groupBox_Reservation.Text = "Reservation Form";
            this.groupBox_Reservation.Enter += new System.EventHandler(this.groupBox_Employee_Enter);
            // 
            // comboBox_Vehicles
            // 
            this.comboBox_Vehicles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.comboBox_Vehicles.FormattingEnabled = true;
            this.comboBox_Vehicles.Location = new System.Drawing.Point(141, 172);
            this.comboBox_Vehicles.Name = "comboBox_Vehicles";
            this.comboBox_Vehicles.Size = new System.Drawing.Size(213, 24);
            this.comboBox_Vehicles.TabIndex = 18;
            this.comboBox_Vehicles.SelectedIndexChanged += new System.EventHandler(this.comboBox_Vehicles_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_Save.Location = new System.Drawing.Point(176, 233);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 36);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vehicle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Phone.Location = new System.Drawing.Point(141, 130);
            this.txtBox_Phone.MaxLength = 50;
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Phone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Email.Location = new System.Drawing.Point(141, 91);
            this.txtBox_Email.MaxLength = 50;
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Email.TabIndex = 2;
            this.txtBox_Email.TextChanged += new System.EventHandler(this.txtBox_Email_TextChanged);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 312);
            this.Controls.Add(this.groupBox_Reservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.groupBox_Reservation.ResumeLayout(false);
            this.groupBox_Reservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Reservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox_Vehicles;
        private System.Windows.Forms.Label label8;
    }
}