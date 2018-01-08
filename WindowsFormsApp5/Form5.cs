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

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Marks] (Id_Stud, Id_Course, Mark, Id_Teacher) VALUES (@Id_Stud, @Id_Course, @Mark, @Id_Teacher )", myConnection);
        

            command1.Parameters.AddWithValue("Id_Stud", textBox1.Text);
            command1.Parameters.AddWithValue("Id_Course", textBox2.Text);
            command1.Parameters.AddWithValue("Mark", textBox3.Text);
            command1.Parameters.AddWithValue("Id_Teacher", textBox4.Text);

            await command1.ExecuteNonQueryAsync();



        }
    }
}
