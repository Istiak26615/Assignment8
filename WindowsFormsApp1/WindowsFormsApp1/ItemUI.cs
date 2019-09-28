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
    public partial class ItemUI : Form
    {
        public ItemUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            add();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            show(); 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();

        }
        public void add()
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string uniqueCommand = @"select*from Items where FoodName='" + foodnameTextBox.Text + "'";
                if (uniqueCommand.Contains(foodnameTextBox.Text))
                {
                    MessageBox.Show("Item must be unique");
                    return;
                }
                string commandString = @"INSERT INTO  Items (FoodName, FoodPrice) Values ('" + foodnameTextBox.Text + "', " + priceTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


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
        public void show()
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                //SELECT * FROM Customers
                string commandString = @"SELECT * FROM Items";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    itemDataGridView.DataSource = dataTable;
                }
                else
                {
                    itemDataGridView.DataSource = null;
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
        public void delete()
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command

                string commandString = @"delete from items where id=" + fidTextBox.Text + "";
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
        public void update()
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command

                string commandString = @"update Items set FoodName ='" + foodnameTextBox.Text + "',FoodPrice='" + priceTextBox.Text + "'Where id=" + fidTextBox.Text + "";
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
        public void search()
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-DHMDHJ9; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                //SELECT * FROM Customers
                string commandString = @"SELECT * FROM Items where id=" + fidTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    itemDataGridView.DataSource = dataTable;
                }
                else
                {
                    itemDataGridView.DataSource = null;
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
 
