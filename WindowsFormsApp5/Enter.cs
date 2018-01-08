using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
  public partial class Enter : Form
  {
    Student s;
    Admin a;
    Teacher t;
    int idType = 0;
    public Enter()
    {
      InitializeComponent();
      button2.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string log = textBox1.Text;
      string pass = textBox2.Text;
      User conn = Connection.GetUser(log, pass);
      string logn= conn.login;
      string passw = conn.password;
      string type = conn.Type;
      int id = conn.Id;
      if (log.Equals(logn) && pass.Equals(passw) && type.Equals("a"))
      {
        a = new Admin();
        a.Show();
        doit(true);
        idType = 1;
      }
      else
      if(log.Equals(logn) && pass.Equals(passw) && type.Equals("s"))
      {
        s = new Student(id);
        s.Show();
        doit(true);
        idType = 2;
      }
      else
      if(log.Equals(logn) && pass.Equals(passw) && type.Equals("t"))
      {
        t = new Teacher(id);
        t.Show();
        doit(true);
        idType = 3;
      }
      else
      {
        MessageBox.Show("Введён неверный логин или пароль");
      }
    }
    void doit(bool a)
    {
      if (a)
      {
        textBox1.Hide();
        textBox2.Hide();
        label1.Hide();
        label2.Hide();
        button1.Hide();
        button2.Show();
        textBox1.Text = "";
        textBox2.Text = "";
      }
      else
      {
        textBox1.Show();
        textBox2.Show();
        label1.Show();
        label2.Show();
        button1.Show();
        button2.Hide();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      doit(false);
      if (idType == 1)
        t.Hide();
      else if (idType == 2)
        s.Hide();
      else if (idType == 3)
        a.Hide();
    }
  }
}
