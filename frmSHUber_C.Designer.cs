namespace SHUber_Database
{
    partial class frmSHUber_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHUber_C));
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuNav = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCust = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJrn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVcl = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustLname = new System.Windows.Forms.Label();
            this.lblCustFname = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustFname = new System.Windows.Forms.TextBox();
            this.txtCustLname = new System.Windows.Forms.TextBox();
            this.txtCustTelNo = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.lblCustTelNo = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.txtCustAvg = new System.Windows.Forms.TextBox();
            this.lblCustAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(66, 90);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1563, 150);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(731, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Customers";
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
            this.mnuNav.Size = new System.Drawing.Size(1702, 30);
            this.mnuNav.TabIndex = 2;
            this.mnuNav.Text = "Nav";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 26);
            this.btnBack.Text = "<<<";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCust
            // 
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(92, 26);
            this.btnCust.Text = "Customers";
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnDri
            // 
            this.btnDri.Name = "btnDri";
            this.btnDri.Size = new System.Drawing.Size(69, 26);
            this.btnDri.Text = "Drivers";
            this.btnDri.Click += new System.EventHandler(this.btnDri_Click);
            // 
            // btnJrn
            // 
            this.btnJrn.Name = "btnJrn";
            this.btnJrn.Size = new System.Drawing.Size(79, 26);
            this.btnJrn.Text = "Journeys";
            this.btnJrn.Click += new System.EventHandler(this.btnJrn_Click);
            // 
            // btnPay
            // 
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(85, 26);
            this.btnPay.Text = "Payments";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnVcl
            // 
            this.btnVcl.Name = "btnVcl";
            this.btnVcl.Size = new System.Drawing.Size(76, 26);
            this.btnVcl.Text = "Vehicles";
            this.btnVcl.Click += new System.EventHandler(this.btnVcl_Click);
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
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.TabIndex = 6;
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
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(176, 265);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(114, 22);
            this.lblCustID.TabIndex = 7;
            this.lblCustID.Text = "Customer ID:";
            // 
            // lblCustLname
            // 
            this.lblCustLname.AutoSize = true;
            this.lblCustLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLname.Location = new System.Drawing.Point(176, 461);
            this.lblCustLname.Name = "lblCustLname";
            this.lblCustLname.Size = new System.Drawing.Size(101, 22);
            this.lblCustLname.TabIndex = 8;
            this.lblCustLname.Text = "Last Name:";
            // 
            // lblCustFname
            // 
            this.lblCustFname.AutoSize = true;
            this.lblCustFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFname.Location = new System.Drawing.Point(176, 364);
            this.lblCustFname.Name = "lblCustFname";
            this.lblCustFname.Size = new System.Drawing.Size(102, 22);
            this.lblCustFname.TabIndex = 9;
            this.lblCustFname.Text = "First Name:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(322, 268);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(466, 22);
            this.txtCustID.TabIndex = 10;
            // 
            // txtCustFname
            // 
            this.txtCustFname.Location = new System.Drawing.Point(322, 368);
            this.txtCustFname.Name = "txtCustFname";
            this.txtCustFname.Size = new System.Drawing.Size(466, 22);
            this.txtCustFname.TabIndex = 11;
            // 
            // txtCustLname
            // 
            this.txtCustLname.Location = new System.Drawing.Point(322, 465);
            this.txtCustLname.Name = "txtCustLname";
            this.txtCustLname.Size = new System.Drawing.Size(466, 22);
            this.txtCustLname.TabIndex = 12;
            // 
            // txtCustTelNo
            // 
            this.txtCustTelNo.Location = new System.Drawing.Point(1025, 368);
            this.txtCustTelNo.Name = "txtCustTelNo";
            this.txtCustTelNo.Size = new System.Drawing.Size(466, 22);
            this.txtCustTelNo.TabIndex = 17;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(1025, 268);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(466, 22);
            this.txtCustEmail.TabIndex = 16;
            // 
            // lblCustTelNo
            // 
            this.lblCustTelNo.AutoSize = true;
            this.lblCustTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTelNo.Location = new System.Drawing.Point(879, 364);
            this.lblCustTelNo.Name = "lblCustTelNo";
            this.lblCustTelNo.Size = new System.Drawing.Size(69, 22);
            this.lblCustTelNo.TabIndex = 15;
            this.lblCustTelNo.Text = "Tel No:";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustEmail.Location = new System.Drawing.Point(879, 265);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(59, 22);
            this.lblCustEmail.TabIndex = 13;
            this.lblCustEmail.Text = "Email:";
            // 
            // txtCustAvg
            // 
            this.txtCustAvg.Location = new System.Drawing.Point(1026, 467);
            this.txtCustAvg.Name = "txtCustAvg";
            this.txtCustAvg.Size = new System.Drawing.Size(466, 22);
            this.txtCustAvg.TabIndex = 19;
            // 
            // lblCustAvg
            // 
            this.lblCustAvg.AutoSize = true;
            this.lblCustAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustAvg.Location = new System.Drawing.Point(880, 463);
            this.lblCustAvg.Name = "lblCustAvg";
            this.lblCustAvg.Size = new System.Drawing.Size(139, 22);
            this.lblCustAvg.TabIndex = 18;
            this.lblCustAvg.Text = "Average Rating:";
            // 
            // frmSHUber_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1702, 705);
            this.Controls.Add(this.txtCustAvg);
            this.Controls.Add(this.lblCustAvg);
            this.Controls.Add(this.txtCustTelNo);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.lblCustTelNo);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.txtCustLname);
            this.Controls.Add(this.txtCustFname);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustFname);
            this.Controls.Add(this.lblCustLname);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.mnuNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuNav;
            this.MinimumSize = new System.Drawing.Size(1720, 752);
            this.Name = "frmSHUber_C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHUber";
            this.Load += new System.EventHandler(this.frmSHUber_C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuNav;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnCust;
        private System.Windows.Forms.ToolStripMenuItem btnDri;
        private System.Windows.Forms.ToolStripMenuItem btnJrn;
        private System.Windows.Forms.ToolStripMenuItem btnPay;
        private System.Windows.Forms.ToolStripMenuItem btnVcl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustLname;
        private System.Windows.Forms.Label lblCustFname;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustFname;
        private System.Windows.Forms.TextBox txtCustLname;
        private System.Windows.Forms.TextBox txtCustTelNo;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label lblCustTelNo;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.TextBox txtCustAvg;
        private System.Windows.Forms.Label lblCustAvg;
    }
}

