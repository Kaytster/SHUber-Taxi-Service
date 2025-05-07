namespace SHUber_Database
{
    partial class frmSHUber_D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHUber_D));
            this.dgvDriver = new System.Windows.Forms.DataGridView();
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
            this.txtDriID = new System.Windows.Forms.TextBox();
            this.lblDriID = new System.Windows.Forms.Label();
            this.lblDriFname = new System.Windows.Forms.Label();
            this.txtDriLname = new System.Windows.Forms.TextBox();
            this.txtDriFname = new System.Windows.Forms.TextBox();
            this.lblDriLname = new System.Windows.Forms.Label();
            this.lblDriAvg = new System.Windows.Forms.Label();
            this.txtDriTelNo = new System.Windows.Forms.TextBox();
            this.txtDriAvg = new System.Windows.Forms.TextBox();
            this.lblDriTelNo = new System.Windows.Forms.Label();
            this.txtDriEmail = new System.Windows.Forms.TextBox();
            this.lblDriEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(66, 90);
            this.dgvDriver.MultiSelect = false;
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.RowHeadersWidth = 51;
            this.dgvDriver.RowTemplate.Height = 24;
            this.dgvDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriver.Size = new System.Drawing.Size(1563, 150);
            this.dgvDriver.TabIndex = 1;
            this.dgvDriver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriver_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(774, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Drivers";
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
            // txtDriID
            // 
            this.txtDriID.Location = new System.Drawing.Point(322, 268);
            this.txtDriID.Name = "txtDriID";
            this.txtDriID.Size = new System.Drawing.Size(466, 22);
            this.txtDriID.TabIndex = 12;
            // 
            // lblDriID
            // 
            this.lblDriID.AutoSize = true;
            this.lblDriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriID.Location = new System.Drawing.Point(176, 265);
            this.lblDriID.Name = "lblDriID";
            this.lblDriID.Size = new System.Drawing.Size(85, 22);
            this.lblDriID.TabIndex = 11;
            this.lblDriID.Text = "Driver ID:";
            // 
            // lblDriFname
            // 
            this.lblDriFname.AutoSize = true;
            this.lblDriFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriFname.Location = new System.Drawing.Point(176, 364);
            this.lblDriFname.Name = "lblDriFname";
            this.lblDriFname.Size = new System.Drawing.Size(102, 22);
            this.lblDriFname.TabIndex = 13;
            this.lblDriFname.Text = "First Name:";
            // 
            // txtDriLname
            // 
            this.txtDriLname.Location = new System.Drawing.Point(322, 465);
            this.txtDriLname.Name = "txtDriLname";
            this.txtDriLname.Size = new System.Drawing.Size(466, 22);
            this.txtDriLname.TabIndex = 14;
            // 
            // txtDriFname
            // 
            this.txtDriFname.Location = new System.Drawing.Point(322, 368);
            this.txtDriFname.Name = "txtDriFname";
            this.txtDriFname.Size = new System.Drawing.Size(466, 22);
            this.txtDriFname.TabIndex = 15;
            // 
            // lblDriLname
            // 
            this.lblDriLname.AutoSize = true;
            this.lblDriLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriLname.Location = new System.Drawing.Point(176, 461);
            this.lblDriLname.Name = "lblDriLname";
            this.lblDriLname.Size = new System.Drawing.Size(101, 22);
            this.lblDriLname.TabIndex = 16;
            this.lblDriLname.Text = "Last Name:";
            // 
            // lblDriAvg
            // 
            this.lblDriAvg.AutoSize = true;
            this.lblDriAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriAvg.Location = new System.Drawing.Point(880, 462);
            this.lblDriAvg.Name = "lblDriAvg";
            this.lblDriAvg.Size = new System.Drawing.Size(139, 22);
            this.lblDriAvg.TabIndex = 22;
            this.lblDriAvg.Text = "Average Rating:";
            // 
            // txtDriTelNo
            // 
            this.txtDriTelNo.Location = new System.Drawing.Point(1026, 369);
            this.txtDriTelNo.Name = "txtDriTelNo";
            this.txtDriTelNo.Size = new System.Drawing.Size(466, 22);
            this.txtDriTelNo.TabIndex = 21;
            // 
            // txtDriAvg
            // 
            this.txtDriAvg.Location = new System.Drawing.Point(1026, 466);
            this.txtDriAvg.Name = "txtDriAvg";
            this.txtDriAvg.Size = new System.Drawing.Size(466, 22);
            this.txtDriAvg.TabIndex = 20;
            // 
            // lblDriTelNo
            // 
            this.lblDriTelNo.AutoSize = true;
            this.lblDriTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriTelNo.Location = new System.Drawing.Point(880, 365);
            this.lblDriTelNo.Name = "lblDriTelNo";
            this.lblDriTelNo.Size = new System.Drawing.Size(69, 22);
            this.lblDriTelNo.TabIndex = 19;
            this.lblDriTelNo.Text = "Tel No:";
            // 
            // txtDriEmail
            // 
            this.txtDriEmail.Location = new System.Drawing.Point(1026, 269);
            this.txtDriEmail.Name = "txtDriEmail";
            this.txtDriEmail.Size = new System.Drawing.Size(466, 22);
            this.txtDriEmail.TabIndex = 18;
            // 
            // lblDriEmail
            // 
            this.lblDriEmail.AutoSize = true;
            this.lblDriEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriEmail.Location = new System.Drawing.Point(880, 266);
            this.lblDriEmail.Name = "lblDriEmail";
            this.lblDriEmail.Size = new System.Drawing.Size(59, 22);
            this.lblDriEmail.TabIndex = 17;
            this.lblDriEmail.Text = "Email:";
            // 
            // frmSHUber_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1702, 705);
            this.Controls.Add(this.lblDriAvg);
            this.Controls.Add(this.txtDriTelNo);
            this.Controls.Add(this.txtDriAvg);
            this.Controls.Add(this.lblDriTelNo);
            this.Controls.Add(this.txtDriEmail);
            this.Controls.Add(this.lblDriEmail);
            this.Controls.Add(this.lblDriLname);
            this.Controls.Add(this.txtDriFname);
            this.Controls.Add(this.txtDriLname);
            this.Controls.Add(this.lblDriFname);
            this.Controls.Add(this.txtDriID);
            this.Controls.Add(this.lblDriID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mnuNav);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvDriver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSHUber_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHUber";
            this.Load += new System.EventHandler(this.frmSHUber_D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
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
        private System.Windows.Forms.TextBox txtDriID;
        private System.Windows.Forms.Label lblDriID;
        private System.Windows.Forms.Label lblDriFname;
        private System.Windows.Forms.TextBox txtDriLname;
        private System.Windows.Forms.TextBox txtDriFname;
        private System.Windows.Forms.Label lblDriLname;
        private System.Windows.Forms.Label lblDriAvg;
        private System.Windows.Forms.TextBox txtDriTelNo;
        private System.Windows.Forms.TextBox txtDriAvg;
        private System.Windows.Forms.Label lblDriTelNo;
        private System.Windows.Forms.TextBox txtDriEmail;
        private System.Windows.Forms.Label lblDriEmail;
    }
}