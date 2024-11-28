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
    public partial class AddForm : Form
    {
        public string strConn = @"Data Source = DESKTOP-DRC69FM\SERVERKM; Initial Catalog = Зоотовары; Integrated Security = True";
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = $"insert into Товар(Артикул,Название, Категория, Бренд, Животное, Описание,Состав,Единица, Стоимость) values (@1,@2,@3,@4,@5,@6,@7,@8,@9)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("1", textBox1.Text);
                    cmd.Parameters.AddWithValue("2", textBox2.Text);
                    cmd.Parameters.AddWithValue("3", textBox3.Text);
                    cmd.Parameters.AddWithValue("4", textBox4.Text);
                    cmd.Parameters.AddWithValue("5", textBox5.Text);
                    cmd.Parameters.AddWithValue("6", textBox6.Text);
                    cmd.Parameters.AddWithValue("7", textBox7.Text);
                    cmd.Parameters.AddWithValue("8", textBox8.Text);
                    cmd.Parameters.AddWithValue("9", textBox9.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }

            this.Hide();
            Products products = new Products();
            products.Show();
        }
    }
}
