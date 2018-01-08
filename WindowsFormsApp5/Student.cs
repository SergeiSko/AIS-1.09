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
using System.Threading;

namespace WindowsFormsApp5
{
  public partial class Student : Form
  {
    int idStd = 0, group;
    string query;
    string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename = C:\Users\Sergei\Documents\Visual Studio 2015\Projects\К показу\WindowsFormsApp5\Db\Database1.mdf;
      Integrated Security=True;";
    int fNam = 0;
    int kolCom = 0;
    bool flagShow = true, flagEdit = false;
    public Student(int id)
    {
      InitializeComponent();
      idStd = id;
      label1.Text = "";
      Thread t = new Thread(Listener);
      t.Start();
      title();
      //MessageBox.Show("Окно: " + this.Width.ToString() + " ДатаГРид: " + dataGridView1.Width.ToString());
    }

    private void отсчиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      flagShow = false;
      flagEdit = true;
    }

    private void моиОценкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Width = 520;
      dataGridView1.Width = 480;
      fNam = 2;
      kolCom = 3;
      dataGridView1.ColumnCount = 3;
      Clear();
      dataGridView1.Columns[0].Name = "Преподователь";
      dataGridView1.Columns[1].Name = "Название предмета";
      dataGridView1.Columns[2].Name = "Оценка";

      query = "SELECT Teachers.Surname, Courses.Course_Name, Marks.Mark" +
      " FROM Courses JOIN Marks ON Courses.Id_Course = Marks.Id_Course" +
      " JOIN Teachers ON Marks.Id_Teacher = Teachers.Id_Teacher" +
      " WHERE Marks.Id_Stud = " + idStd;
      моиОценки();
    }

    private void моиПредметыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Width = 420;
      dataGridView1.Width = 380;
      fNam = 1;
      kolCom = 1;
      dataGridView1.ColumnCount = 1;
      Clear();
      dataGridView1.Columns[0].Name = "Предмет";
      query = @"SELECT Course_Name
      FROM Courses JOIN Students_Courses
      ON Courses.Id_Course = Students_Courses.Id_Course
      JOIN Students
      ON Students_Courses.Groups = Students.Groups
      WHERE Id_Stud = " + idStd;
      моиПредметы();
    }

    private void мояГруппаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Width = 620;
      dataGridView1.Width = 580;
      fNam = 3;
      kolCom = 4;
      dataGridView1.ColumnCount = 4;
      Clear();
      dataGridView1.Columns[0].Name = "Студент";
      dataGridView1.Columns[1].Name = "Преподователь";
      dataGridView1.Columns[2].Name = "Название предмета";
      dataGridView1.Columns[3].Name = "Оценка";

      query = String.Format("SELECT Students.Surname, Teachers.Surname, Courses.Course_Name, Marks.Mark" +
      " FROM Courses JOIN Marks ON Courses.Id_Course = Marks.Id_Course" +
      " JOIN Teachers ON Marks.Id_Teacher = Teachers.Id_Teacher" +
      " JOIN Students ON Marks.Id_Stud = Students.Id_Stud" +
      " WHERE Students.Groups = " + group);
      моиОценки();
    }

    void моиОценки()
    {
      SqlConnection conn = new SqlConnection(connStr);
      conn.Open();
      
      SqlCommand command = new SqlCommand(query, conn);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[kolCom]);
        for(int i = 0; i < kolCom; i++)
          data[data.Count - 1][i] = reader[i].ToString();
      }

      foreach (string[] s in data)
        dataGridView1.Rows.Add(s);

      reader.Close();
      conn.Close();
      label1.Text = "";
    }
    void моиПредметы()
    {
      SqlConnection conn = new SqlConnection(connStr);
      conn.Open();
      SqlCommand command = new SqlCommand(query, conn);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[1]);
        for (int i = 0; i < kolCom; i++)
          data[data.Count - 1][i] = reader[i].ToString();
      }

      reader.Close();
      conn.Close();

      foreach (string[] s in data)
        dataGridView1.Rows.Add(s);
    }
    void мояГруппа()
    {
      SqlConnection conn = new SqlConnection(connStr);
      conn.Open();
      SqlCommand command = new SqlCommand(query, conn);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[1]);
        data[data.Count - 1][0] = reader[0].ToString();
      }

      reader.Close();
      conn.Close();

      foreach (string[] s in data)
        dataGridView1.Rows.Add(s);
    }
    void Clear()
    {
      dataGridView1.Rows.Clear();
      for (int i = 0; i < kolCom; i++)
        dataGridView1.Columns[i].Name = "";
      label1.Text = "";
    }
    
    private void обновитьToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      switch (fNam)
      {
        case 1:
          {
            моиПредметы();
            break;
          }
        case 2:
          {
            моиОценки();
            break;
          }
        case 3:
          {
            моиОценки();
            break;
          }
      }
    }

    private void Student_Load(object sender, EventArgs e)
    {

    }

    void Listener()
    {
      for(;;)
      {
        Thread.Sleep(500);
        if (flagEdit)
        {
          if (flagShow)
          {
            Show();
          }
          else
          {
            Hide();
          }
          flagEdit = false;
        }
      }
    }

    void title()
    {
      SqlConnection conn = new SqlConnection(connStr);
      conn.Open();
      query = @"SELECT Surname, Name, Patronymic, Groups
      FROM Students
      WHERE Id_Stud = " + idStd;
      SqlCommand command = new SqlCommand(query, conn);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[1]);
        this.Text += reader[0].ToString() + " ";
        this.Text += reader[1].ToString() + " ";
        this.Text += reader[2].ToString();
        group = Convert.ToInt32(reader[3]);
      }
      
      reader.Close();
      conn.Close();
    }
  }
}
