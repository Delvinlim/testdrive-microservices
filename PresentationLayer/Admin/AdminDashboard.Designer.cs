
namespace PresentationLayer
{
    partial class ShowroomTestDriveManagement
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_Vehicles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.btn_Reservations);
            this.sidePanel.Controls.Add(this.btn_Vehicles);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(6);
            this.sidePanel.Size = new System.Drawing.Size(215, 749);
            this.sidePanel.TabIndex = 0;
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reservations.FlatAppearance.BorderSize = 0;
            this.btn_Reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reservations.Font = new System.Drawing.Font("Fira Code", 12.25F);
            this.btn_Reservations.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Reservations.Location = new System.Drawing.Point(6, 197);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(201, 99);
            this.btn_Reservations.TabIndex = 3;
            this.btn_Reservations.Text = "Reservations";
            this.btn_Reservations.UseVisualStyleBackColor = false;
            this.btn_Reservations.Click += new System.EventHandler(this.btn_Reservations_Click);
            // 
            // btn_Vehicles
            // 
            this.btn_Vehicles.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Vehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Vehicles.FlatAppearance.BorderSize = 0;
            this.btn_Vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vehicles.Font = new System.Drawing.Font("Fira Code", 12.25F);
            this.btn_Vehicles.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Vehicles.Location = new System.Drawing.Point(6, 98);
            this.btn_Vehicles.Name = "btn_Vehicles";
            this.btn_Vehicles.Size = new System.Drawing.Size(201, 99);
            this.btn_Vehicles.TabIndex = 2;
            this.btn_Vehicles.Text = "Vehicles";
            this.btn_Vehicles.UseVisualStyleBackColor = false;
            this.btn_Vehicles.Click += new System.EventHandler(this.btn_Vehicle_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADM TESTDRIVE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contentFlowPanel
            // 
            this.contentFlowPanel.AutoScroll = true;
            this.contentFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentFlowPanel.Location = new System.Drawing.Point(215, 0);
            this.contentFlowPanel.Name = "contentFlowPanel";
            this.contentFlowPanel.Size = new System.Drawing.Size(930, 749);
            this.contentFlowPanel.TabIndex = 1;
            this.contentFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentFlowPanel_Paint);
            // 
            // ShowroomTestDriveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1145, 749);
            this.Controls.Add(this.contentFlowPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "ShowroomTestDriveManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showroom Test Drive Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminManagementApp_FormClosed);
            this.Load += new System.EventHandler(this.AdminManagementApp_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_Vehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel contentFlowPanel;
    }
}