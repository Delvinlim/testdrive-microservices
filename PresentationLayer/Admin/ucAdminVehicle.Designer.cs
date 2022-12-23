
namespace PresentationLayer
{
    partial class ucAdminVehicle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_deleteVehicle = new System.Windows.Forms.Button();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.dgv_Vehicles = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_deleteVehicle);
            this.groupBox2.Controls.Add(this.btn_addVehicle);
            this.groupBox2.Controls.Add(this.dgv_Vehicles);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 537);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicles List";
            // 
            // btn_deleteVehicle
            // 
            this.btn_deleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteVehicle.Location = new System.Drawing.Point(164, 44);
            this.btn_deleteVehicle.Name = "btn_deleteVehicle";
            this.btn_deleteVehicle.Size = new System.Drawing.Size(140, 35);
            this.btn_deleteVehicle.TabIndex = 3;
            this.btn_deleteVehicle.Text = "Delete Vehicle";
            this.btn_deleteVehicle.UseVisualStyleBackColor = true;
            this.btn_deleteVehicle.Click += new System.EventHandler(this.btn_deleteVehicle_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addVehicle.Location = new System.Drawing.Point(6, 44);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(140, 35);
            this.btn_addVehicle.TabIndex = 1;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = true;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // dgv_Vehicles
            // 
            this.dgv_Vehicles.AllowUserToAddRows = false;
            this.dgv_Vehicles.AllowUserToDeleteRows = false;
            this.dgv_Vehicles.AllowUserToOrderColumns = true;
            this.dgv_Vehicles.AllowUserToResizeColumns = false;
            this.dgv_Vehicles.AllowUserToResizeRows = false;
            this.dgv_Vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vehicles.Location = new System.Drawing.Point(6, 85);
            this.dgv_Vehicles.MultiSelect = false;
            this.dgv_Vehicles.Name = "dgv_Vehicles";
            this.dgv_Vehicles.ReadOnly = true;
            this.dgv_Vehicles.RowHeadersWidth = 51;
            this.dgv_Vehicles.RowTemplate.Height = 24;
            this.dgv_Vehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Vehicles.Size = new System.Drawing.Size(814, 446);
            this.dgv_Vehicles.TabIndex = 0;
            this.dgv_Vehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vehicles_CellContentClick);
            // 
            // ucAdminVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ucAdminVehicle";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(886, 597);
            this.Load += new System.EventHandler(this.ucAdminVehicle_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Vehicles;
        private System.Windows.Forms.Button btn_deleteVehicle;
        private System.Windows.Forms.Button btn_addVehicle;
    }
}
