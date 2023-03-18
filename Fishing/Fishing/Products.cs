using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fishing
{
    public partial class Products : Form

    {
        static string connectionString = @"Data Source=DESKTOP-9E3T9JQ;Initial Catalog=Trade3;Integrated Security =True;";
        SqlConnection connection = new SqlConnection(connectionString);
        Color col = ColorTranslator.FromHtml("#7fff00");
        //SqlConnection connection;
        public Products()
        {
           
            InitializeComponent();
        }

        private void productsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Filter.SelectedIndex)
            {
                case 0:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount <3";
                    break;
                case 2:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount >=3 and ProductDiscountAmount<=4";
                    break;
                case 3:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount >=5";
                    break;


            }
            change_count();
           
        }
        private void change_count()
        {
            int count_rows;
            count_rows = productsGrid.Rows.Count;
            currentLb1.Text = count_rows.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //поиск
            (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE '%{Poick.Text}%'";
            change_count();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
                string allProducts = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(allProducts, connection);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                productsGrid.DataSource = ds.Tables[0];
                productsGrid.Columns[0].Visible = false;
                productsGrid.Columns[11].Visible = false;

                overallLb1.Text = (productsGrid.Rows.Count - 1).ToString();
                change_count();
            }

        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            string request = $"Select * from Product WHERE ProductArticleNumber='{productsGrid.CurrentRow.Cells[0].Value}'";

            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            Disk.Text = reader["ProductQuantityInStock"].ToString();
            Op.Text = reader["ProductDescription"].ToString();
            Proz.Text = reader["ProductManufacturer"].ToString();
            Costt.Text = reader["ProductCost"].ToString();

            
        }

        private void productsGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //скидка
            int valu = Convert.ToInt32(productsGrid.Rows[e.RowIndex].Cells[7].Value);
            if (valu > 3)
            {
                productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = col;
            }
        }

        private void Dobav_Click(object sender, EventArgs e)
        {
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                Dobavlen dbv = new Dobavlen();
                dbv.Show();
            }
        }
    }
     
}
