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
    public partial class EditForm : Form
    {
        public string strConn = @"Data Source = DESKTOP-DRC69FM\SERVERKM; Initial Catalog = Зоотовары; Integrated Security = True";
        DataGridViewRow data;
        public EditForm(DataGridViewRow edit)
        {
            InitializeComponent();
            data = edit;
            textBox1.Text = data.Cells["артикулDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox2.Text = data.Cells["названиеDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox3.Text = data.Cells["категорияDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox4.Text = data.Cells["брендDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox5.Text = data.Cells["животноеDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox6.Text = data.Cells["описаниеDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox7.Text = data.Cells["составDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox8.Text = data.Cells["единицаDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            textBox9.Text = data.Cells["стоимостьDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = $"update Товар set Артикул = @1, Название = @2, Категория = @3, Бренд = @4, Животное = @5, Описание = @6,Состав = @7,Единица = @8, Стоимость = @9 where ID = @ID";
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
                    cmd.Parameters.AddWithValue("ID", data.Cells["iDDataGridViewTextBoxColumn"].Value?.ToString());
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
