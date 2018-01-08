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
  public partial class Form6 : Form
  {
    public bool shows = false;
    public Form6()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string log = textBox1.Text;
      string pass = textBox2.Text;
      User conn = Connection.GetUser(log, pass);
      string logn = conn.login;
      string passw = conn.password;
      if (log.Equals(logn) && pass.Equals(passw))
      {
        Hide();
        //MessageBox.Show("Добро пожаловать");
        Form2 f2 = new Form2();
        f2.Show();
      }
      else
      {
        //MessageBox.Show("Введён неверный логин или пароль");
      }
    }
  }
}
