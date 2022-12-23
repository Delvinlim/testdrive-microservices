namespace presentationTier.Admin
{
    partial class VehiclesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox_Reservation = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Image = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Displacement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Length = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.groupBox_Reservation.SuspendLayout();
            this.SuspendLayout();
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
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(141, 50);
            this.txtBox_Name.MaxLength = 16;
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Name.TabIndex = 0;
            // 
            // groupBox_Reservation
            // 
            this.groupBox_Reservation.Controls.Add(this.label8);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Height);
            this.groupBox_Reservation.Controls.Add(this.label7);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Width);
            this.groupBox_Reservation.Controls.Add(this.label6);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Length);
            this.groupBox_Reservation.Controls.Add(this.label5);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Speed);
            this.groupBox_Reservation.Controls.Add(this.label4);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Displacement);
            this.groupBox_Reservation.Controls.Add(this.btn_Save);
            this.groupBox_Reservation.Controls.Add(this.label3);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Image);
            this.groupBox_Reservation.Controls.Add(this.label2);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Price);
            this.groupBox_Reservation.Controls.Add(this.label1);
            this.groupBox_Reservation.Controls.Add(this.txtBox_Name);
            this.groupBox_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox_Reservation.Location = new System.Drawing.Point(14, 14);
            this.groupBox_Reservation.Name = "groupBox_Reservation";
            this.groupBox_Reservation.Size = new System.Drawing.Size(766, 339);
            this.groupBox_Reservation.TabIndex = 3;
            this.groupBox_Reservation.TabStop = false;
            this.groupBox_Reservation.Text = "Vehicles";
            this.groupBox_Reservation.Enter += new System.EventHandler(this.groupBox_Reservation_Enter);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_Save.Location = new System.Drawing.Point(566, 282);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 36);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image Url";
            // 
            // txtBox_Image
            // 
            this.txtBox_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Image.Location = new System.Drawing.Point(141, 130);
            this.txtBox_Image.MaxLength = 50;
            this.txtBox_Image.Name = "txtBox_Image";
            this.txtBox_Image.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Image.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.Location = new System.Drawing.Point(141, 91);
            this.txtBox_Price.MaxLength = 50;
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Price.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Displacement";
            // 
            // txtBox_Displacement
            // 
            this.txtBox_Displacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Displacement.Location = new System.Drawing.Point(141, 174);
            this.txtBox_Displacement.MaxLength = 16;
            this.txtBox_Displacement.Name = "txtBox_Displacement";
            this.txtBox_Displacement.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Displacement.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max Speed";
            // 
            // txtBox_Speed
            // 
            this.txtBox_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Speed.Location = new System.Drawing.Point(517, 53);
            this.txtBox_Speed.MaxLength = 16;
            this.txtBox_Speed.Name = "txtBox_Speed";
            this.txtBox_Speed.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Speed.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Length";
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Length.Location = new System.Drawing.Point(517, 94);
            this.txtBox_Length.MaxLength = 16;
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Length.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Width";
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Width.Location = new System.Drawing.Point(517, 133);
            this.txtBox_Width.MaxLength = 16;
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Width.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Height";
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Height.Location = new System.Drawing.Point(517, 177);
            this.txtBox_Height.MaxLength = 16;
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(213, 22);
            this.txtBox_Height.TabIndex = 25;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 367);
            this.Controls.Add(this.groupBox_Reservation);
            this.Name = "VehiclesForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "VehiclesForm";
            this.groupBox_Reservation.ResumeLayout(false);
            this.groupBox_Reservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.GroupBox groupBox_Reservation;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Displacement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_Length;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Speed;
    }
}