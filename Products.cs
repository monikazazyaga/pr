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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Зоомагазин
{
    public partial class Products : Form
    {
        public string strConn = @"Data Source = DESKTOP-DRC69FM\SERVERKM; Initial Catalog = Зоотовары; Integrated Security = True";

        public Products()
        {
            InitializeComponent();
            comboBoxFilter.Items.Add("все");
            categoryId.Add(0);
            AddCategories(category);
        }


        List<int> categoryId = new List<int>();
        List<string> category = new List<string>();

        public void AddCategories(List<string> category)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "select * from Категория";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categoryId.Add((int)reader.GetSqlInt32(0));
                    category.Add((string)reader.GetSqlString(1));
                }
                foreach(var c  in category)
                {
                    comboBoxFilter.Items.Add(c);
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зоотоварыDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.зоотоварыDataSet.Товар);

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            int categorySelect = comboBoxFilter.SelectedIndex;
            if(categorySelect == 0)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = "select * from Товар";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                dataGridViewProduct.DataSource = dataTable;
            }
            else
            {
                int categoryIdSelected = categoryId[categoryId.Count - (categorySelect)];
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = "select * from Товар where Категория = @category";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("category", categoryIdSelected);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                dataGridViewProduct.DataSource = dataTable;
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "SELECT * FROM Товар WHERE Название LIKE @searchTerm";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("searchTerm", "%" + searchTerm + "%"); 
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            dataGridViewProduct.DataSource = dataTable;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string sortColumn = "Название"; 
            string sortOrder = "ASC"; 
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = $"SELECT * FROM Товар ORDER BY {sortColumn} {sortOrder}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            dataGridViewProduct.DataSource = dataTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProduct.SelectedRows[0];
                this.Hide();
                EditForm editForm = new EditForm(selectedRow);
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите товар");
            }  
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProduct.SelectedRows[0];
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM Товар  where ID = @ID";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("ID", selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value?.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch 
                {
                    MessageBox.Show("Произошла ошибка.");
                }
            }
            else
            {
                MessageBox.Show("Выберите товар");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login= new Login();
            login.Show();
        }
    }
}
