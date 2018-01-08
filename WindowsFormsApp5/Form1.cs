using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
  public partial class Form1 : Form
  {
    Form6 f6 = new Form6();
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!(f6.shows))
      {
        f6.Show();
        f6.shows = true;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      f6.Close();
      Close();
    }
  }
}