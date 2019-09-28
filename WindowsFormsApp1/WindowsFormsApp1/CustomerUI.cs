using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command

                string commandString = @"INSERT INTO  Customers (Name, Address, Contact) Values ('" + customernameTextBox.Text + "', '" + addressTextBox.Text + "','" + contactTextBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                
                if (commandString.Contains(customernameTextBox.Text))
                {
                    MessageBox.Show("Customer Name must be unique");
                    return;
                }
                //Open
                sqlConnection.Open();

                //Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }
    

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                //SELECT * FROM Customers
                string commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    customerDataGridView.DataSource = dataTable;
                }
                else
                {
                    customerDataGridView.DataSource = null;
                    MessageBox.Show("No Data Found");
                }


                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command

                string commandString = @"delete from Customers where id=" + cidTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command

                string commandString = @"update Customers set Name ='" + customernameTextBox.Text + "',Address='" + addressTextBox.Text + "',Contact='" + contactTextBox.Text + "'Where id=" + cidTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                //SELECT * FROM Customers
                string commandString = @"SELECT * FROM Customers where id=" + cidTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    customerDataGridView.DataSource = dataTable;
                }
                else
                {
                    customerDataGridView.DataSource = null;
                    MessageBox.Show("No Data Found");
                }


                //Close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

        }
    }
}
