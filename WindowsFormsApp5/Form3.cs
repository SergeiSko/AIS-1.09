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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Students] (Id_Stud,Groups, Surname, Name, Patronymic) VALUES (@Id_Stud, @Groups, @Surname, @Name, @Patronymic)", myConnection);


            command1.Parameters.AddWithValue("Id_Stud", textBox1.Text);
            command1.Parameters.AddWithValue("Groups", textBox2.Text);
            command1.Parameters.AddWithValue("Surname", textBox3.Text);
            command1.Parameters.AddWithValue("Name", textBox4.Text);
            command1.Parameters.AddWithValue("Patronymic", textBox5.Text);

            await command1.ExecuteNonQueryAsync();


            

        }
    }
}

