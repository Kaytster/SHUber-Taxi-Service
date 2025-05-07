namespace SHUber_Database
{
    partial class frmSHUber_V
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHUber_V));
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuNav = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCust = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJrn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVcl = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtVclID = new System.Windows.Forms.TextBox();
            this.lblVclID = new System.Windows.Forms.Label();
            this.txtVclName = new System.Windows.Forms.TextBox();
            this.lblVclName = new System.Windows.Forms.Label();
            this.lblVclDriID = new System.Windows.Forms.Label();
            this.txtVclDriID = new System.Windows.Forms.TextBox();
            this.txtVclLicence = new System.Windows.Forms.TextBox();
            this.lblVclLicence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(66, 90);
            this.dgvVehicle.MultiSelect = false;
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(1563, 150);
            this.dgvVehicle.TabIndex = 1;
            this.dgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(757, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Vehicles";
            // 
            // mnuNav
            // 
            this.mnuNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.mnuNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnCust,
            this.btnDri,
            this.btnJrn,
            this.btnPay,
            this.btnVcl});
            this.mnuNav.Location = new System.Drawing.Point(0, 0);
            this.mnuNav.Name = "mnuNav";
            this.mnuNav.Size = new System.Drawing.Size(1702, 28);
            this.mnuNav.TabIndex = 3;
            this.mnuNav.Text = "Nav";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 24);
            this.btnBack.Text = "<<<";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCust
            // 
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(92, 24);
            this.btnCust.Text = "Customers";
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnDri
            // 
            this.btnDri.Name = "btnDri";
            this.btnDri.Size = new System.Drawing.Size(69, 24);
            this.btnDri.Text = "Drivers";
            this.btnDri.Click += new System.EventHandler(this.btnDri_Click);
            // 
            // btnJrn
            // 
            this.btnJrn.Name = "btnJrn";
            this.btnJrn.Size = new System.Drawing.Size(79, 24);
            this.btnJrn.Text = "Journeys";
            this.btnJrn.Click += new System.EventHandler(this.btnJrn_Click);
            // 
            // btnPay
            // 
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(85, 24);
            this.btnPay.Text = "Payments";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnVcl
            // 
            this.btnVcl.Name = "btnVcl";
            this.btnVcl.Size = new System.Drawing.Size(76, 24);
            this.btnVcl.Text = "Vehicles";
            this.btnVcl.Click += new System.EventHandler(this.btnVcl_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1233, 604);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 89);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(884, 604);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 89);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(528, 604);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(260, 89);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(179, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 89);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtVclID
            // 
            this.txtVclID.Location = new System.Drawing.Point(322, 288);
            this.txtVclID.Name = "txtVclID";
            this.txtVclID.Size = new System.Drawing.Size(466, 22);
            this.txtVclID.TabIndex = 12;
            // 
            // lblVclID
            // 
            this.lblVclID.AutoSize = true;
            this.lblVclID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVclID.Location = new System.Drawing.Point(176, 285);
            this.lblVclID.Name = "lblVclID";
            this.lblVclID.Size = new System.Drawing.Size(96, 22);
            this.lblVclID.TabIndex = 11;
            this.lblVclID.Text = "Vehicle ID:";
            // 
            // txtVclName
            // 
            this.txtVclName.Location = new System.Drawing.Point(322, 445);
            this.txtVclName.Name = "txtVclName";
            this.txtVclName.Size = new System.Drawing.Size(466, 22);
            this.txtVclName.TabIndex = 14;
            // 
            // lblVclName
            // 
            this.lblVclName.AutoSize = true;
            this.lblVclName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVclName.Location = new System.Drawing.Point(176, 441);
            this.lblVclName.Name = "lblVclName";
            this.lblVclName.Size = new System.Drawing.Size(126, 22);
            this.lblVclName.TabIndex = 16;
            this.lblVclName.Text = "Vehicle Name:";
            // 
            // lblVclDriID
            // 
            this.lblVclDriID.AutoSize = true;
            this.lblVclDriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVclDriID.Location = new System.Drawing.Point(880, 441);
            this.lblVclDriID.Name = "lblVclDriID";
            this.lblVclDriID.Size = new System.Drawing.Size(85, 22);
            this.lblVclDriID.TabIndex = 22;
            this.lblVclDriID.Text = "Driver ID:";
            // 
            // txtVclDriID
            // 
            this.txtVclDriID.Location = new System.Drawing.Point(1026, 445);
            this.txtVclDriID.Name = "txtVclDriID";
            this.txtVclDriID.Size = new System.Drawing.Size(466, 22);
            this.txtVclDriID.TabIndex = 20;
            // 
            // txtVclLicence
            // 
            this.txtVclLicence.Location = new System.Drawing.Point(1026, 288);
            this.txtVclLicence.Name = "txtVclLicence";
            this.txtVclLicence.Size = new System.Drawing.Size(466, 22);
            this.txtVclLicence.TabIndex = 18;
            // 
            // lblVclLicence
            // 
            this.lblVclLicence.AutoSize = true;
            this.lblVclLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVclLicence.Location = new System.Drawing.Point(880, 285);
            this.lblVclLicence.Name = "lblVclLicence";
            this.lblVclLicence.Size = new System.Drawing.Size(141, 22);
            this.lblVclLicence.TabIndex = 17;
            this.lblVclLicence.Text = "Vehicle Licence:";
            // 
            // frmSHUber_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1702, 705);
            this.Controls.Add(this.lblVclDriID);
            this.Controls.Add(this.txtVclDriID);
            this.Controls.Add(this.txtVclLicence);
            this.Controls.Add(this.lblVclLicence);
            this.Controls.Add(this.lblVclName);
            this.Controls.Add(this.txtVclName);
            this.Controls.Add(this.txtVclID);
            this.Controls.Add(this.lblVclID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mnuNav);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvVehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSHUber_V";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHUber";
            this.Load += new System.EventHandler(this.frmSHUber_V_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuNav;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnCust;
        private System.Windows.Forms.ToolStripMenuItem btnDri;
        private System.Windows.Forms.ToolStripMenuItem btnJrn;
        private System.Windows.Forms.ToolStripMenuItem btnPay;
        private System.Windows.Forms.ToolStripMenuItem btnVcl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVclID;
        private System.Windows.Forms.Label lblVclID;
        private System.Windows.Forms.TextBox txtVclName;
        private System.Windows.Forms.Label lblVclName;
        private System.Windows.Forms.Label lblVclDriID;
        private System.Windows.Forms.TextBox txtVclDriID;
        private System.Windows.Forms.TextBox txtVclLicence;
        private System.Windows.Forms.Label lblVclLicence;
    }
}