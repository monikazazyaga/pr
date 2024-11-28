using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоомагазин
{
    public partial class Login : Form
    {
        public string strConn = @"Data Source = DESKTOP-DRC69FM\SERVERKM; Initial Catalog = Зоотовары; Integrated Security = True";

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name;
            bool log = false;
            try 
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = "select * from Клиент where Логин = @login and Пароль = @password";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("password", textBoxPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        name = (string)reader.GetSqlString(0);
                        log = true;
                        MessageBox.Show("Добрый день, " + name);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
            if (log)
            {
                this.Hide();
                Products products = new Products();
                products.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
            
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }



        //ALTER TABLE Orders
        //ADD FOREIGN KEY(CustomerId) REFERENCES Customers(Id);
        //Personid int IDENTITY(1,1) PRIMARY KEY,
        //Данные филтр, данные текст по столбцам
    }
}
