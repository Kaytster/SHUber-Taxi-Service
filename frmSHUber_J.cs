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
    public partial class frmSHUber_J : Form
    {
        public frmSHUber_J()
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

        private void frmSHUber_J_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=SHUber.db");
            connection.Open();

            string query = "SELECT * FROM Journey";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);

            dgvJourney.DataSource = data;

            connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtJrnID.Text = "";
            txtJrnDrop.Text = "";
            txtJrnPick.Text = "";
            txtJrnDT.Text = "";
            txtJrnCost.Text = "";
            txtJrnCustID.Text = "";
            txtJrnDriID.Text = "";
            txtJrnCustR.Text = "";
            txtJrnDriR.Text = "";
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
            string addQuery = "INSERT INTO Journey(Journey_ID, Pickup_Loc, DropOff_Loc, Journey_Date_Time, Cost, Cust_ID, Driver_ID, Cust_Rating, Driver_Rating) " + "VALUES('" + txtJrnID.Text + "','" + txtJrnDrop.Text + "','" + txtJrnPick.Text + "','" + txtJrnDT.Text + "','" + txtJrnCost.Text + "','" + txtJrnCustID.Text + "','" + txtJrnDriID.Text + "','" + txtJrnCustR.Text + "','" + txtJrnDriR.Text + "')";
            AmendDatabase(addQuery);
            LoadData();
        }

        private void dgvJourney_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtJrnID.Text = dgvJourney.SelectedRows[0].Cells[0].Value.ToString();
            txtJrnDrop.Text = dgvJourney.SelectedRows[0].Cells[1].Value.ToString();
            txtJrnPick.Text = dgvJourney.SelectedRows[0].Cells[2].Value.ToString();
            txtJrnDT.Text = dgvJourney.SelectedRows[0].Cells[3].Value.ToString();
            txtJrnCost.Text = dgvJourney.SelectedRows[0].Cells[4].Value.ToString();
            txtJrnCustID.Text = dgvJourney.SelectedRows[0].Cells[5].Value.ToString();
            txtJrnDriID.Text = dgvJourney.SelectedRows[0].Cells[6].Value.ToString();
            txtJrnCustR.Text = dgvJourney.SelectedRows[0].Cells[7].Value.ToString();
            txtJrnDriR.Text = dgvJourney.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editSQL = "UPDATE Journey SET Pickup_Loc='" + txtJrnPick.Text + "'," + "DropOff_Loc = '" + txtJrnDrop.Text + "'," + "Journey_Date_Time = '" + txtJrnDT.Text + "'," + "Cost = '" + txtJrnCost.Text + "'," + "Cust_Rating = '" + txtJrnCustR.Text  + "'," + "Driver_Rating = '" + txtJrnDriR.Text + "' WHERE Cust_ID='" + txtJrnCustID.Text + "'," + "Driver_ID = '" + txtJrnDriID.Text + "'," + "Journey_ID = '" + txtJrnID.Text + "'";
            AmendDatabase(editSQL);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delSQL = "DELETE FROM Journey WHERE Journey_ID = '" + txtJrnID.Text + "'";
            AmendDatabase(delSQL);
            LoadData();
        }
    }
}
