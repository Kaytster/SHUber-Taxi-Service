namespace SHUber_Database
{
    partial class frmSHUber_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHUber_P));
            this.dgvPayment = new System.Windows.Forms.DataGridView();
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
            this.txtPayID = new System.Windows.Forms.TextBox();
            this.lblPayID = new System.Windows.Forms.Label();
            this.lblPayCustID = new System.Windows.Forms.Label();
            this.txtPayJrnID = new System.Windows.Forms.TextBox();
            this.txtPayCustID = new System.Windows.Forms.TextBox();
            this.lblPayJrnID = new System.Windows.Forms.Label();
            this.txtPayCardT = new System.Windows.Forms.TextBox();
            this.lblPayCardT = new System.Windows.Forms.Label();
            this.txtPayCardD = new System.Windows.Forms.TextBox();
            this.lblPayCardD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(66, 90);
            this.dgvPayment.MultiSelect = false;
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(1563, 150);
            this.dgvPayment.TabIndex = 1;
            this.dgvPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(742, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Payments";
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
            // txtPayID
            // 
            this.txtPayID.Location = new System.Drawing.Point(322, 268);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(466, 22);
            this.txtPayID.TabIndex = 12;
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayID.Location = new System.Drawing.Point(176, 265);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(107, 22);
            this.lblPayID.TabIndex = 11;
            this.lblPayID.Text = "Payment ID:";
            // 
            // lblPayCustID
            // 
            this.lblPayCustID.AutoSize = true;
            this.lblPayCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayCustID.Location = new System.Drawing.Point(176, 364);
            this.lblPayCustID.Name = "lblPayCustID";
            this.lblPayCustID.Size = new System.Drawing.Size(114, 22);
            this.lblPayCustID.TabIndex = 13;
            this.lblPayCustID.Text = "Customer ID:";
            // 
            // txtPayJrnID
            // 
            this.txtPayJrnID.Location = new System.Drawing.Point(322, 465);
            this.txtPayJrnID.Name = "txtPayJrnID";
            this.txtPayJrnID.Size = new System.Drawing.Size(466, 22);
            this.txtPayJrnID.TabIndex = 14;
            // 
            // txtPayCustID
            // 
            this.txtPayCustID.Location = new System.Drawing.Point(322, 368);
            this.txtPayCustID.Name = "txtPayCustID";
            this.txtPayCustID.Size = new System.Drawing.Size(466, 22);
            this.txtPayCustID.TabIndex = 15;
            // 
            // lblPayJrnID
            // 
            this.lblPayJrnID.AutoSize = true;
            this.lblPayJrnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayJrnID.Location = new System.Drawing.Point(176, 461);
            this.lblPayJrnID.Name = "lblPayJrnID";
            this.lblPayJrnID.Size = new System.Drawing.Size(101, 22);
            this.lblPayJrnID.TabIndex = 16;
            this.lblPayJrnID.Text = "Journey ID:";
            // 
            // txtPayCardT
            // 
            this.txtPayCardT.Location = new System.Drawing.Point(1026, 368);
            this.txtPayCardT.Name = "txtPayCardT";
            this.txtPayCardT.Size = new System.Drawing.Size(466, 22);
            this.txtPayCardT.TabIndex = 21;
            // 
            // lblPayCardT
            // 
            this.lblPayCardT.AutoSize = true;
            this.lblPayCardT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayCardT.Location = new System.Drawing.Point(880, 364);
            this.lblPayCardT.Name = "lblPayCardT";
            this.lblPayCardT.Size = new System.Drawing.Size(100, 22);
            this.lblPayCardT.TabIndex = 19;
            this.lblPayCardT.Text = "Card Type:";
            // 
            // txtPayCardD
            // 
            this.txtPayCardD.Location = new System.Drawing.Point(1026, 268);
            this.txtPayCardD.Name = "txtPayCardD";
            this.txtPayCardD.Size = new System.Drawing.Size(466, 22);
            this.txtPayCardD.TabIndex = 18;
            // 
            // lblPayCardD
            // 
            this.lblPayCardD.AutoSize = true;
            this.lblPayCardD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayCardD.Location = new System.Drawing.Point(880, 265);
            this.lblPayCardD.Name = "lblPayCardD";
            this.lblPayCardD.Size = new System.Drawing.Size(114, 22);
            this.lblPayCardD.TabIndex = 17;
            this.lblPayCardD.Text = "Card Details:";
            // 
            // frmSHUber_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1702, 705);
            this.Controls.Add(this.txtPayCardT);
            this.Controls.Add(this.lblPayCardT);
            this.Controls.Add(this.txtPayCardD);
            this.Controls.Add(this.lblPayCardD);
            this.Controls.Add(this.lblPayJrnID);
            this.Controls.Add(this.txtPayCustID);
            this.Controls.Add(this.txtPayJrnID);
            this.Controls.Add(this.lblPayCustID);
            this.Controls.Add(this.txtPayID);
            this.Controls.Add(this.lblPayID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mnuNav);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSHUber_P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHUber";
            this.Load += new System.EventHandler(this.frmSHUber_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayment;
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
        private System.Windows.Forms.TextBox txtPayID;
        private System.Windows.Forms.Label lblPayID;
        private System.Windows.Forms.Label lblPayCustID;
        private System.Windows.Forms.TextBox txtPayJrnID;
        private System.Windows.Forms.TextBox txtPayCustID;
        private System.Windows.Forms.Label lblPayJrnID;
        private System.Windows.Forms.TextBox txtPayCardT;
        private System.Windows.Forms.Label lblPayCardT;
        private System.Windows.Forms.TextBox txtPayCardD;
        private System.Windows.Forms.Label lblPayCardD;
    }
}