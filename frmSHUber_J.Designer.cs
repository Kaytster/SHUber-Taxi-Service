namespace SHUber_Database
{
    partial class frmSHUber_J
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHUber_J));
            this.dgvJourney = new System.Windows.Forms.DataGridView();
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
            this.txtJrnID = new System.Windows.Forms.TextBox();
            this.lblJrnID = new System.Windows.Forms.Label();
            this.lblJrnDrop = new System.Windows.Forms.Label();
            this.txtJrnPick = new System.Windows.Forms.TextBox();
            this.txtJrnDrop = new System.Windows.Forms.TextBox();
            this.lblJrnPick = new System.Windows.Forms.Label();
            this.lblJrnDriR = new System.Windows.Forms.Label();
            this.txtJrnCustR = new System.Windows.Forms.TextBox();
            this.txtJrnDriR = new System.Windows.Forms.TextBox();
            this.lblJrnCustR = new System.Windows.Forms.Label();
            this.txtJrnDriID = new System.Windows.Forms.TextBox();
            this.lblJrnDriID = new System.Windows.Forms.Label();
            this.lblJrnCustID = new System.Windows.Forms.Label();
            this.txtJrnCost = new System.Windows.Forms.TextBox();
            this.txtJrnCustID = new System.Windows.Forms.TextBox();
            this.lblJrnCost = new System.Windows.Forms.Label();
            this.txtJrnDT = new System.Windows.Forms.TextBox();
            this.lblJrnDT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourney)).BeginInit();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJourney
            // 
            this.dgvJourney.AllowUserToAddRows = false;
            this.dgvJourney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJourney.Location = new System.Drawing.Point(66, 90);
            this.dgvJourney.MultiSelect = false;
            this.dgvJourney.Name = "dgvJourney";
            this.dgvJourney.ReadOnly = true;
            this.dgvJourney.RowHeadersWidth = 51;
            this.dgvJourney.RowTemplate.Height = 24;
            this.dgvJourney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJourney.Size = new System.Drawing.Size(1563, 150);
            this.dgvJourney.TabIndex = 1;
            this.dgvJourney.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJourney_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(748, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Journeys";
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
            // txtJrnID
            // 
            this.txtJrnID.Location = new System.Drawing.Point(229, 271);
            this.txtJrnID.Name = "txtJrnID";
            this.txtJrnID.Size = new System.Drawing.Size(336, 22);
            this.txtJrnID.TabIndex = 12;
            // 
            // lblJrnID
            // 
            this.lblJrnID.AutoSize = true;
            this.lblJrnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnID.Location = new System.Drawing.Point(83, 268);
            this.lblJrnID.Name = "lblJrnID";
            this.lblJrnID.Size = new System.Drawing.Size(101, 22);
            this.lblJrnID.TabIndex = 11;
            this.lblJrnID.Text = "Journey ID:";
            // 
            // lblJrnDrop
            // 
            this.lblJrnDrop.AutoSize = true;
            this.lblJrnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnDrop.Location = new System.Drawing.Point(28, 369);
            this.lblJrnDrop.Name = "lblJrnDrop";
            this.lblJrnDrop.Size = new System.Drawing.Size(156, 22);
            this.lblJrnDrop.TabIndex = 13;
            this.lblJrnDrop.Text = "Drop Off Location:";
            // 
            // txtJrnPick
            // 
            this.txtJrnPick.Location = new System.Drawing.Point(229, 468);
            this.txtJrnPick.Name = "txtJrnPick";
            this.txtJrnPick.Size = new System.Drawing.Size(336, 22);
            this.txtJrnPick.TabIndex = 14;
            // 
            // txtJrnDrop
            // 
            this.txtJrnDrop.Location = new System.Drawing.Point(229, 371);
            this.txtJrnDrop.Name = "txtJrnDrop";
            this.txtJrnDrop.Size = new System.Drawing.Size(336, 22);
            this.txtJrnDrop.TabIndex = 15;
            // 
            // lblJrnPick
            // 
            this.lblJrnPick.AutoSize = true;
            this.lblJrnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnPick.Location = new System.Drawing.Point(34, 464);
            this.lblJrnPick.Name = "lblJrnPick";
            this.lblJrnPick.Size = new System.Drawing.Size(150, 22);
            this.lblJrnPick.TabIndex = 16;
            this.lblJrnPick.Text = "Pick Up Location:";
            // 
            // lblJrnDriR
            // 
            this.lblJrnDriR.AutoSize = true;
            this.lblJrnDriR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnDriR.Location = new System.Drawing.Point(1133, 464);
            this.lblJrnDriR.Name = "lblJrnDriR";
            this.lblJrnDriR.Size = new System.Drawing.Size(120, 22);
            this.lblJrnDriR.TabIndex = 22;
            this.lblJrnDriR.Text = "Driver Rating:";
            // 
            // txtJrnCustR
            // 
            this.txtJrnCustR.Location = new System.Drawing.Point(1279, 371);
            this.txtJrnCustR.Name = "txtJrnCustR";
            this.txtJrnCustR.Size = new System.Drawing.Size(336, 22);
            this.txtJrnCustR.TabIndex = 21;
            // 
            // txtJrnDriR
            // 
            this.txtJrnDriR.Location = new System.Drawing.Point(1279, 468);
            this.txtJrnDriR.Name = "txtJrnDriR";
            this.txtJrnDriR.Size = new System.Drawing.Size(336, 22);
            this.txtJrnDriR.TabIndex = 20;
            // 
            // lblJrnCustR
            // 
            this.lblJrnCustR.AutoSize = true;
            this.lblJrnCustR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnCustR.Location = new System.Drawing.Point(1133, 367);
            this.lblJrnCustR.Name = "lblJrnCustR";
            this.lblJrnCustR.Size = new System.Drawing.Size(149, 22);
            this.lblJrnCustR.TabIndex = 19;
            this.lblJrnCustR.Text = "Customer Rating:";
            // 
            // txtJrnDriID
            // 
            this.txtJrnDriID.Location = new System.Drawing.Point(1279, 271);
            this.txtJrnDriID.Name = "txtJrnDriID";
            this.txtJrnDriID.Size = new System.Drawing.Size(336, 22);
            this.txtJrnDriID.TabIndex = 18;
            // 
            // lblJrnDriID
            // 
            this.lblJrnDriID.AutoSize = true;
            this.lblJrnDriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnDriID.Location = new System.Drawing.Point(1133, 268);
            this.lblJrnDriID.Name = "lblJrnDriID";
            this.lblJrnDriID.Size = new System.Drawing.Size(85, 22);
            this.lblJrnDriID.TabIndex = 17;
            this.lblJrnDriID.Text = "Driver ID:";
            // 
            // lblJrnCustID
            // 
            this.lblJrnCustID.AutoSize = true;
            this.lblJrnCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnCustID.Location = new System.Drawing.Point(610, 464);
            this.lblJrnCustID.Name = "lblJrnCustID";
            this.lblJrnCustID.Size = new System.Drawing.Size(114, 22);
            this.lblJrnCustID.TabIndex = 28;
            this.lblJrnCustID.Text = "Customer ID:";
            // 
            // txtJrnCost
            // 
            this.txtJrnCost.Location = new System.Drawing.Point(756, 371);
            this.txtJrnCost.Name = "txtJrnCost";
            this.txtJrnCost.Size = new System.Drawing.Size(336, 22);
            this.txtJrnCost.TabIndex = 27;
            // 
            // txtJrnCustID
            // 
            this.txtJrnCustID.Location = new System.Drawing.Point(756, 468);
            this.txtJrnCustID.Name = "txtJrnCustID";
            this.txtJrnCustID.Size = new System.Drawing.Size(336, 22);
            this.txtJrnCustID.TabIndex = 26;
            // 
            // lblJrnCost
            // 
            this.lblJrnCost.AutoSize = true;
            this.lblJrnCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnCost.Location = new System.Drawing.Point(610, 367);
            this.lblJrnCost.Name = "lblJrnCost";
            this.lblJrnCost.Size = new System.Drawing.Size(52, 22);
            this.lblJrnCost.TabIndex = 25;
            this.lblJrnCost.Text = "Cost:";
            // 
            // txtJrnDT
            // 
            this.txtJrnDT.Location = new System.Drawing.Point(756, 271);
            this.txtJrnDT.Name = "txtJrnDT";
            this.txtJrnDT.Size = new System.Drawing.Size(336, 22);
            this.txtJrnDT.TabIndex = 24;
            // 
            // lblJrnDT
            // 
            this.lblJrnDT.AutoSize = true;
            this.lblJrnDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJrnDT.Location = new System.Drawing.Point(610, 268);
            this.lblJrnDT.Name = "lblJrnDT";
            this.lblJrnDT.Size = new System.Drawing.Size(133, 22);
            this.lblJrnDT.TabIndex = 23;
            this.lblJrnDT.Text = "Date and Time:";
            // 
            // frmSHUber_J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1702, 705);
            this.Controls.Add(this.lblJrnCustID);
            this.Controls.Add(this.txtJrnCost);
            this.Controls.Add(this.txtJrnCustID);
            this.Controls.Add(this.lblJrnCost);
            this.Controls.Add(this.txtJrnDT);
            this.Controls.Add(this.lblJrnDT);
            this.Controls.Add(this.lblJrnDriR);
            this.Controls.Add(this.txtJrnCustR);
            this.Controls.Add(this.txtJrnDriR);
            this.Controls.Add(this.lblJrnCustR);
            this.Controls.Add(this.txtJrnDriID);
            this.Controls.Add(this.lblJrnDriID);
            this.Controls.Add(this.lblJrnPick);
            this.Controls.Add(this.txtJrnDrop);
            this.Controls.Add(this.txtJrnPick);
            this.Controls.Add(this.lblJrnDrop);
            this.Controls.Add(this.txtJrnID);
            this.Controls.Add(this.lblJrnID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mnuNav);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvJourney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSHUber_J";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHUber";
            this.Load += new System.EventHandler(this.frmSHUber_J_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourney)).EndInit();
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJourney;
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
        private System.Windows.Forms.TextBox txtJrnID;
        private System.Windows.Forms.Label lblJrnID;
        private System.Windows.Forms.Label lblJrnDrop;
        private System.Windows.Forms.TextBox txtJrnPick;
        private System.Windows.Forms.TextBox txtJrnDrop;
        private System.Windows.Forms.Label lblJrnPick;
        private System.Windows.Forms.Label lblJrnDriR;
        private System.Windows.Forms.TextBox txtJrnCustR;
        private System.Windows.Forms.TextBox txtJrnDriR;
        private System.Windows.Forms.Label lblJrnCustR;
        private System.Windows.Forms.TextBox txtJrnDriID;
        private System.Windows.Forms.Label lblJrnDriID;
        private System.Windows.Forms.Label lblJrnCustID;
        private System.Windows.Forms.TextBox txtJrnCost;
        private System.Windows.Forms.TextBox txtJrnCustID;
        private System.Windows.Forms.Label lblJrnCost;
        private System.Windows.Forms.TextBox txtJrnDT;
        private System.Windows.Forms.Label lblJrnDT;
    }
}