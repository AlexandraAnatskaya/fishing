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

namespace Fishing
{
    public partial class Dobavlen : Form
    {
        static string connectionString = @"Data Source=DESKTOP-9E3T9JQ;Initial Catalog=Trade3;Integrated Security =True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public Dobavlen()
        {
            InitializeComponent();
        }

        private void Dobavlen_Load(object sender, EventArgs e)
        {

        }

        private void DobClick_Click(object sender, EventArgs e)
        {
            //добавление 
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "DobProd35";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductDescription", ProductDescription.Text);
            command.Parameters.AddWithValue("@ProductManufacturer", ProductManufacturer.Text);
            command.Parameters.AddWithValue("@ProductCost", ProductCost.Text);
            command.Parameters.AddWithValue("@ProductArticleNumber", ProductArticleNumber.Text);
            command.Parameters.AddWithValue("@ProductName", ProductName.Text);
            command.Parameters.AddWithValue("@ProductCategory", ProductCategory.Text);
            command.Parameters.AddWithValue("@ProductQuantityInStock", ProductQuantityInStock.Text);

            //сообщение
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Успешно!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}"); ;
            }
        }

        private void ProductQuantityInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') || (e.KeyChar == '.') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
