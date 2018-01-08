using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
  public static class Connection
  {
    static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";

    public static User GetUser(string Login, string Password)
    {
      User user = new User();
      SqlConnection conn = new SqlConnection(connectionString);
      try
      {
        conn.Open();
        SqlCommand command2 = new SqlCommand(
        String.Format("SELECT * FROM [dbo].[Users] /*user*/ " +
                      "WHERE Users.password = '{0}' AND Users.login = '{1}'", Password, Login), conn);
        SqlDataReader reader = command2.ExecuteReader();
        while (reader.Read())
        {
          user.Id = reader.GetInt32(0);
          user.login = reader.GetValue(1).ToString();
          user.password = reader["password"].ToString();
          user.Type = reader.GetValue(3).ToString();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Введён неверный логин или пароль.\n" + ex.Message);
      }
      finally
      {
        conn.Close();
      }
      return user;
    }
  }
}