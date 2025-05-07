using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHUber_Database
{
    public partial class frmSHUber_V : Form
    {
        public frmSHUber_V()
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

        private void frmSHUber_V_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=SHUber.db");
            connection.Open();

            string query = "SELECT * FROM Vehicle";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);

            dgvVehicle.DataSource = data;

            connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtVclID.Text = "";
            txtVclName.Text = "";
            txtVclLicence.Text = "";
            txtVclDriID.Text = "";
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
            string addQuery = "INSERT INTO Customer(Vehicle_ID, Vehicle_Name, Vehicle_Licence, Driver_ID) " + "VALUES('" + txtVclID.Text + "','" + txtVclName.Text + "','" + txtVclLicence.Text + "','" + txtVclDriID.Text + "')";
            AmendDatabase(addQuery);
            LoadData();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVclID.Text = dgvVehicle.SelectedRows[0].Cells[0].Value.ToString();
            txtVclName.Text = dgvVehicle.SelectedRows[0].Cells[1].Value.ToString();
            txtVclLicence.Text = dgvVehicle.SelectedRows[0].Cells[2].Value.ToString();
            txtVclDriID.Text = dgvVehicle.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editSQL = "UPDATE Vehicle SET Vehicle_Name='" + txtVclName.Text + "'," + "Vehicle_Licence = '" + txtVclLicence.Text + "'," + "Driver_ID = '" + txtVclDriID.Text + "' WHERE Vehicle_ID='" + txtVclID.Text + "'";
            AmendDatabase(editSQL);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delSQL = "DELETE FROM Vehicle WHERE Vehicle_ID = '" + txtVclID.Text + "'";
            AmendDatabase(delSQL);
            LoadData();
        }
    }
}
