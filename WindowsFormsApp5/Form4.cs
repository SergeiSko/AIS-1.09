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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
           
           string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Teachers] (Id_Teacher, Surname, Name, Patronymic) VALUES (@Id_Teacher, @Surname, @Name, @Patronymic )", myConnection);
            SqlCommand command2 = new SqlCommand("INSERT INTO [Teachers_Courses] (Id_Teacher, Id_Course) VALUES (@Id_Teacher, @Id_Course)", myConnection);
            SqlCommand command3 = new SqlCommand("INSERT INTO [Courses] (Id_Course, Course_Name) VALUES (@Id_Course, @Course_Name)", myConnection);

            command1.Parameters.AddWithValue("Id_Teacher", textBox1.Text);
            command1.Parameters.AddWithValue("Surname", textBox2.Text);
            command1.Parameters.AddWithValue("Name", textBox3.Text);
            command1.Parameters.AddWithValue("Patronymic", textBox4.Text);

            command2.Parameters.AddWithValue("Id_Teacher", textBox1.Text);
            command2.Parameters.AddWithValue("Id_Course", textBox5.Text);


            command3.Parameters.AddWithValue("Id_Course", textBox5.Text);
            command3.Parameters.AddWithValue("Course_Name", textBox6.Text);

            await command1.ExecuteNonQueryAsync();

            await command2.ExecuteNonQueryAsync();
            await command3.ExecuteNonQueryAsync();




        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
