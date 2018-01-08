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
  public partial class Teacher : Form
  {
    string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename = C:\Users\Sergei\Documents\Visual Studio 2015\Projects\К показу\WindowsFormsApp5\Db\Database1.mdf;
      Integrated Security=True;";
    string query;
    bool flagShow = true, flagEdit = false;
    int kolCom = 0;
    int ThisID;

    public Teacher(int id)
    {
      ThisID = id;
      InitializeComponent();
      title(id);
      label1.Text = "";
    }

    
    private void списокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 4;
      label1.Text = "Список студентов группы №2234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[4];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";

      string query = "SELECT Students.Id_Stud, Students.Surname, Students.Name, Students.Patronymic " +
      "FROM Students WHERE Students.Groups = '2234'";

      LoadDate(kolCom, query, nameCol);
    }

    private void списокПредметовToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 1;
      label1.Text = "Список предметов группы №1234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;
      string[] nameCol = new string[1];
      dataGridView1.Columns[0].HeaderText = "Предмет";

      string query = "SELECT DISTINCT Courses.Course_Name " +
      "FROM Students_Courses JOIN Students " +
      "ON Students.Groups = Students_Courses.Groups JOIN Courses " +
      "ON Students_Courses.Id_Course = Courses.Id_Course  WHERE Students.Groups = '1234'";

      LoadDate(kolCom, query, nameCol);
    }

    private void своднаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 6;
      label1.Text = "Cводная таблица успеваемости";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[6];
      nameCol[0] = "№ группы";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Предмет";
      nameCol[4] = "Оценка";
      nameCol[5] = "Преподаватель";

      string query = "SELECT Students.Groups, Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark, Teachers.Surname " +
      "FROM Marks JOIN Students " +
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses " +
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers " +
      "ON Marks.Id_Teacher = Teachers.Id_Teacher " +
      "WHERE Teachers.Id_Teacher = " + ThisID;

      LoadDate(kolCom, query, nameCol);
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 5;
      label1.Text = "Успеваемость группы №1234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0] = "Фамилия";
      nameCol[1] = "Имя";
      nameCol[2] = "Предмет";
      nameCol[3] = "Оценка";
      nameCol[4] = "Преподаватель";

      string query = "SELECT Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark, Teachers.Surname " +
      "FROM Marks JOIN Students " +
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses " +
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers " +
      "ON Marks.Id_Teacher = Teachers.Id_Teacher WHERE Students.Groups = '1234' " +
      "AND Teachers.Id_Teacher = " + ThisID;
      LoadDate(kolCom, query, nameCol);
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 5;
      label1.Text = "Успеваемость группы №2234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0] = "Фамилия";
      nameCol[1] = "Имя";
      nameCol[2] = "Предмет";
      nameCol[3] = "Оценка";
      nameCol[4] = "Преподаватель";

      string query = "SELECT Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark, Teachers.Surname " +
      "FROM Marks JOIN Students " +
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses " +
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers " +
      "ON Marks.Id_Teacher = Teachers.Id_Teacher WHERE Students.Groups = '2234' " +
      "AND Teachers.Id_Teacher = " + ThisID;
      LoadDate(kolCom, query, nameCol);
    }

    private void списокНеаттестованыхToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 5;
      label1.Text = "Cписок неаттестованных";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0] = "№ группы";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Предмет";
      nameCol[4] = "Оценка";

      string query = "SELECT Students.Groups, Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark " +
      "FROM Marks JOIN Students " +
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses " +
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers " +
      "ON Marks.Id_Course = Teachers.Id_Courses " +
      "WHERE Marks.Mark = '2' " +
      "AND Teachers.Id_Teacher = " + ThisID;

      LoadDate(kolCom, query, nameCol);
    }
    void LoadDate(int kolСolumns, string query, string[] str)
    {
      for (int i = 0; i < kolСolumns; i++)
        dataGridView1.Columns[i].HeaderText = str[i];
      SqlConnection myConnection = new SqlConnection(connStr);
      myConnection.Open();
      SqlCommand command = new SqlCommand(query, myConnection);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[kolСolumns]);
        for (int i = 0; i < kolСolumns; i++)
          data[data.Count - 1][i] = reader[i].ToString();
      }

      reader.Close();
      myConnection.Close();

      foreach (string[] s in data)
        dataGridView1.Rows.Add(s);
    }
    void Clear()
    {
      dataGridView1.Rows.Clear();
      for (int i = 0; i < kolCom; i++)
        dataGridView1.Columns[i].HeaderText = "";
      label1.Text = "";
    }

    private void cписокСтудентовToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Clear();
      kolCom = 4;
      label1.Text = "Список студентов группы №1234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";
      string query = "SELECT Students.Id_Stud, Students.Surname, Students.Name, Students.Patronymic " +
      "FROM Students WHERE Students.Groups = '1234'";

      LoadDate(kolCom, query, nameCol);
    }

    private void списокПредметовToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Clear();
      kolCom = 1;
      dataGridView1.Columns[0].Width = 200;
      label1.Text = "Список предметов группы №1234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[1];
      dataGridView1.Columns[0].HeaderText = "Предмет";

      string query = "SELECT DISTINCT Courses.Course_Name " +
      "FROM Students_Courses JOIN Students " +
      "ON Students.Groups = Students_Courses.Groups JOIN Courses " +
      "ON Students_Courses.Id_Course = Courses.Id_Course  WHERE Students.Groups = '1234'";

      LoadDate(kolCom, query, nameCol);
    }

    private void списокСтудентовToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Clear();
      kolCom = 4;
      label1.Text = "Список студентов группы №2234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[4];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";

      string query = "SELECT Students.Id_Stud, Students.Surname, Students.Name, Students.Patronymic " +
      "FROM Students WHERE Students.Groups = '2234'";

      LoadDate(kolCom, query, nameCol);
    }

    private void списокПредметовToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Clear();
      kolCom = 1;
      dataGridView1.Columns[0].Width = 200;
      label1.Text = "Список предметов группы №2234";
      dataGridView1.ColumnCount = kolCom;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[1];
      dataGridView1.Columns[0].HeaderText = "Предмет";

      string query = "SELECT DISTINCT Courses.Course_Name " +
      "FROM Students_Courses JOIN Students " +
      "ON Students.Groups = Students_Courses.Groups JOIN Courses " +
      "ON Students_Courses.Id_Course = Courses.Id_Course  WHERE Students.Groups = '2234'";

      LoadDate(kolCom, query, nameCol);
    }

    void title(int idStd)
    {
      SqlConnection conn = new SqlConnection(connStr);
      conn.Open();
      query = @"SELECT Surname, Name, Patronymic
      FROM Teachers
      WHERE Id_Teacher = " + idStd;
      SqlCommand command = new SqlCommand(query, conn);
      SqlDataReader reader = command.ExecuteReader();
      List<string[]> data = new List<string[]>();

      while (reader.Read())
      {
        data.Add(new string[1]);
        this.Text += reader[0].ToString() + " ";
        this.Text += reader[1].ToString() + " ";
        this.Text += reader[2].ToString();
      }
      reader.Close();
      conn.Close();
    }
    void Listener()
    {
      for (;;)
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
  }
}
