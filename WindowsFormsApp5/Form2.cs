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
  public partial class Form2 : Form
  {
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
    Integrated Security=True";
    int kCol;
    public bool flag_Enter = false;

    public Form2()
    {
      Thread lis = new Thread(Listener);
      InitializeComponent();
      dataGridView1.RowHeadersVisible = false;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 5;
      label1.Text = "Список преподавателей";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;
      
      dataGridView1.Columns[4].Width = 200;

      string[] nameCol = new string[5];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";
      nameCol[4] = "Предмет";
      string query = "SELECT Teachers.Id_Teacher, Teachers.Surname, Teachers.Name,Teachers.Patronymic, Courses.Course_Name "+ 
      " FROM Teachers_Courses JOIN Teachers "+
      "ON Teachers_Courses.Id_Teacher = Teachers.Id_Teacher JOIN Courses "+
      "ON Teachers_Courses.Id_Course = Courses.Id_Course ORDER BY Id_Teacher";
      LoadDate(kCol, query, nameCol);
    }
    private void cписокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 4;
      label1.Text = "Список студентов группы №1234";
      
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";
      string query = "SELECT Students.Id_Stud, Students.Surname, Students.Name, Students.Patronymic "+
      "FROM Students WHERE Students.Groups = '1234'";
      
      LoadDate(kCol, query, nameCol);
    }

    private void списокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 4;
      label1.Text = "Список студентов группы №2234";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[4];
      nameCol[0] = "Id";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Отчество";

      string query = "SELECT Students.Id_Stud, Students.Surname, Students.Name, Students.Patronymic "+
      "FROM Students WHERE Students.Groups = '2234'";

      LoadDate(kCol, query, nameCol);
    }

    private void списокПредметовToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 1;
      dataGridView1.Columns[0].Width = 200;
      label1.Text = "Список предметов группы №1234";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[1];
      dataGridView1.Columns[0].HeaderText = "Предмет";

      string query = "SELECT DISTINCT Courses.Course_Name "+
      "FROM Students_Courses JOIN Students "+
      "ON Students.Groups = Students_Courses.Groups JOIN Courses "+
      "ON Students_Courses.Id_Course = Courses.Id_Course  WHERE Students.Groups = '1234'";
      
      LoadDate(kCol, query, nameCol);
    }

    private void поГруппамToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void своднаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 6;
      dataGridView1.Columns[0].Width = 100;
      dataGridView1.Columns[3].Width = 200;
      dataGridView1.Columns[4].Width = 80;

      label1.Text = "Cводная таблица успеваемости";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[6];
      nameCol[0] = "№ группы";
      nameCol[1] = "Фамилия";
      nameCol[2] = "Имя";
      nameCol[3] = "Предмет";
      nameCol[4] = "Оценка";
      nameCol[5] = "Преподаватель";

      string query = "SELECT Students.Groups, Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark, Teachers.Surname "+
      "FROM Marks JOIN Students "+
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses "+
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers "+
      "ON Marks.Id_Teacher = Teachers.Id_Teacher ";
      
      LoadDate(kCol, query, nameCol);
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 5;
      dataGridView1.Columns[2].Width = 200;
      label1.Text = "Успеваемость группы №1234";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;
      
      string[] nameCol = new string[5];
      nameCol[0] = "Фамилия";
      nameCol[1] = "Имя";
      nameCol[2] = "Предмет";
      nameCol[3] = "Оценка";
      nameCol[4] = "Преподаватель";
      
      string query = "SELECT Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark, Teachers.Surname "+
      "FROM Marks JOIN Students "+
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses "+
      "ON Marks.Id_Course = Courses.Id_Course JOIN Teachers "+
      "ON Marks.Id_Teacher = Teachers.Id_Teacher WHERE Students.Groups = '1234' ";
      LoadDate(kCol, query, nameCol);
    }

    private void списокНеаттестованыхToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 5;
      label1.Text = "Cписок неаттестованных";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.Columns[0].Width = 120;
      dataGridView1.Columns[3].Width = 200;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[5];
      nameCol[0]= "№ группы";
      nameCol[1]= "Фамилия";
      nameCol[2]= "Имя";
      nameCol[3]= "Предмет";
      nameCol[4]= "Оценка";

      string query = "SELECT Students.Groups, Students.Surname, Students.Name, Courses.Course_Name, Marks.Mark "+
      "FROM Marks JOIN Students "+
      "ON Marks.Id_Stud = Students.Id_Stud JOIN Courses "+
      "ON Marks.Id_Course = Courses.Id_Course WHERE Marks.Mark = '2' ";
      
      LoadDate(kCol, query, nameCol);
    }
    private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form3 f3 = new Form3();
      f3.Show();
    }

    private void добавитьПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form4 f4 = new Form4();
      f4.Show();
    }

    private void добавитьОценкуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form5 f5 = new Form5();
      f5.Show();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      MessageBox.Show("Оно самое");
    }
    
    private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SqlConnection myConnection = new SqlConnection(connectionString);
      myConnection.Open();
      foreach (DataGridViewCell cell in dataGridView1.SelectedCells)//производим поиск выбранной ячейки
      {
        dataGridView1.Rows.RemoveAt(cell.RowIndex);// удаляем строчку
      }
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 5;
      dataGridView1.Columns[2].Width = 200;
      label1.Text = "Успеваемость группы №2234";
      dataGridView1.ColumnCount = kCol;
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
      "ON Marks.Id_Teacher = Teachers.Id_Teacher WHERE Students.Groups = '2234' ";
      LoadDate(kCol, query, nameCol);
    }

    private void списокПредметовToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Clear();
      kCol = 1;
      dataGridView1.Columns[0].Width = 200;
      label1.Text = "Список предметов группы №2234";
      dataGridView1.ColumnCount = kCol;
      dataGridView1.ColumnHeadersVisible = true;

      string[] nameCol = new string[1];
      dataGridView1.Columns[0].HeaderText = "Предмет";

      string query = "SELECT DISTINCT Courses.Course_Name " +
      "FROM Students_Courses JOIN Students " +
      "ON Students.Groups = Students_Courses.Groups JOIN Courses " +
      "ON Students_Courses.Id_Course = Courses.Id_Course  WHERE Students.Groups = '2234'";

      LoadDate(kCol, query, nameCol);
    }
    void LoadDate(int kolСolumns, string query, string[] str)
    {
      for(int i = 0; i < kolСolumns; i++)
      dataGridView1.Columns[i].HeaderText = str[i];
      SqlConnection myConnection = new SqlConnection(connectionString);
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
      for (int i = 0; i < kCol; i++)
        dataGridView1.Columns[i].HeaderText = "";
      label1.Text = "";
    }
    void Listener()
    {
      if(flag_Enter)
      {
        Show();
      }
    }

    private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clear();
    }
  }
}