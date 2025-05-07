using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SHUber_Database
{
    public partial class frmSHUber_C : Form
    {
        public frmSHUber_C()
        {
            InitializeComponent();
        }

        //Navigation Menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Hide();
            frmSHUber_C c = new frmSHUber_C();
            c.Show();
        }

        private void btnDri_Click(object sender, EventArgs e)
        {
            Hide();
            frmSHUber_D d = new frmSHUber_D();
            d.Show();
        }

        private void btnJrn_Click(object sender, EventArgs e)
        {
            Hide();
            frmSHUber_J j = new frmSHUber_J();
            j.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Hide();
            frmSHUber_P p = new frmSHUber_P();
            p.Show();
        }

        private void btnVcl_Click(object sender, EventArgs e)
        {
            Hide();
            frmSHUber_V v = new frmSHUber_V();
            v.Show();
        }

        private void frmSHUber_C_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=SHUber.db");
            connection.Open();

            string query = "SELECT * FROM Customer";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);

            dgvCustomer.DataSource = data;

            connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtCustID.Text = "";
            txtCustFname.Text = "";
            txtCustLname.Text = "";
            txtCustEmail.Text = "";
            txtCustTelNo.Text = "";
            txtCustAvg.Text = "";
        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = SHUber.db");
            connection.Open();
            string query = txtQuery;
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

            clearTextFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string addQuery = "INSERT INTO Customer(Cust_ID, Cust_Fname, Cust_Lname, Cust_Email, Cust_TelNo, Cust_Avg_Rate) " + 
                "VALUES('"+txtCustID.Text+"','"+txtCustFname.Text+"','"+txtCustLname.Text+"','"+txtCustEmail.Text+"','"+txtCustTelNo.Text+"','"+txtCustAvg.Text+"')";
            AmendDatabase(addQuery);
            LoadData();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustID.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtCustFname.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtCustLname.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtCustEmail.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txtCustTelNo.Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
            txtCustAvg.Text = dgvCustomer.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editSQL = "UPDATE Customer SET Cust_Fname='" + txtCustFname.Text + "'," + "Cust_Lname = '" + txtCustLname.Text + "'," + "Cust_Email = '" + txtCustEmail.Text + "'," + "Cust_TelNo = '" + txtCustTelNo.Text + "'," + "Cust_Avg_Rate = '" + txtCustAvg.Text + "' WHERE Cust_ID='" + txtCustID.Text + "'";
            AmendDatabase(editSQL);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delSQL = "DELETE FROM Customer WHERE Cust_ID = '" + txtCustID.Text + "'";
            AmendDatabase(delSQL);
            LoadData();
        }
    }
}
