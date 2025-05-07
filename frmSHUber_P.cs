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
    public partial class frmSHUber_P : Form
    {
        public frmSHUber_P()
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

        private void frmSHUber_P_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=SHUber.db");
            connection.Open();

            string query = "SELECT * FROM Payment";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);

            dgvPayment.DataSource = data;

            connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtPayID.Text = "";
            txtPayCustID.Text = "";
            txtPayJrnID.Text = "";
            txtPayCardD.Text = "";
            txtPayCardT.Text = "";
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
            string addQuery = "INSERT INTO Customer(Payment_ID, Cust_ID, Journey_ID, Card_Details, Card_Type) " + "VALUES('" + txtPayID.Text + "','" + txtPayCustID.Text + "','" + txtPayJrnID.Text + "','" + txtPayCardD.Text + "','" + txtPayCardT.Text + "')";
            AmendDatabase(addQuery);
            LoadData();
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayID.Text = dgvPayment.SelectedRows[0].Cells[0].Value.ToString();
            txtPayCustID.Text = dgvPayment.SelectedRows[0].Cells[1].Value.ToString();
            txtPayJrnID.Text = dgvPayment.SelectedRows[0].Cells[2].Value.ToString();
            txtPayCardD.Text = dgvPayment.SelectedRows[0].Cells[3].Value.ToString();
            txtPayCardT.Text = dgvPayment.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editSQL = "UPDATE Payment SET Card_Details='" + txtPayCardD.Text + "'," + "Card_Type = '" + txtPayCardT.Text + "' WHERE Payment_ID='" + txtPayID.Text + "'," + "Cust_ID='" + txtPayCustID.Text + "'," + "Journey_ID='" + txtPayJrnID.Text + ",";
            AmendDatabase(editSQL);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delSQL = "DELETE FROM Payment WHERE Payment_ID = '" + txtPayID.Text + "'";
            AmendDatabase(delSQL);
            LoadData();
        }
    }
}
