using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace FIT
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Password == "123")
            {
                MainWindow adm = new MainWindow();
                adm.Show();
                this.Hide();
            }
            else
            {
                txtUser.Text = "";
                txtPass.Password = "";

                MessageBox.Show("Проверьте логин и пароль");
            }
        }









        //   private void Button_Click(object sender, RoutedEventArgs e)
        //   {
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=APPK-MAIN;Initial Catalog=FIT;Integrated Security=True");
        //  string query = "Select * from login where login = '" + txtUser.Text.Trim() + "' and password = '" + txtPass.Password.Trim() + "'";
        //  SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

        //  DataTable dtbl = new DataTable();
        //  sda.Fill(dtbl);

        //
        //     if (dtbl.Rows.Count == 1)
        //     {
        //       if (dtbl.Rows[0]["id"].ToString() == "1")
        //       {
        // MainWindow adm = new MainWindow();
        //           this.Hide();
        //  adm.Show();
        // }             
        //      else
        //      {
        //  MessageBox.Show("Роль не определена");
        //  }
        // }
        //   else
        //  {
        // MessageBox.Show("Проверьте логин и пароль");
        // }
        // }
    }
}
