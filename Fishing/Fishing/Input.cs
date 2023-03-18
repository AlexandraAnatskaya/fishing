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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Fishing
{
    public partial class Input : Form

    {
        static string connectionString = @"Data Source=DESKTOP-9E3T9JQ;Initial Catalog=Trade3;Integrated Security =True;";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public Input()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            
                connection.Close();
                connection.Open();
                string request = $"SELECT * FROM [User] WHERE UserLogin='{LoginT.Text}' and UserPassword='{PasswordT.Text}'";


                SqlCommand command = connection.CreateCommand();
                command.CommandText = "cheack_login3";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserLogin", LoginT.Text);
                command.Parameters.AddWithValue("@UserPassword", PasswordT.Text);
                int numb = command.ExecuteNonQuery();

                SqlCommand loginSel = new SqlCommand(request, connection);
                SqlDataReader connectionString = command.ExecuteReader();
                connectionString.Read();
               // bool isCorrect;
            

            if (connectionString.HasRows)
            {
                MessageBox.Show("Успешно!");
                this.Hide();
                Products newForm = new Products();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка!");




            }
                   

            }
    }
}

            
        

