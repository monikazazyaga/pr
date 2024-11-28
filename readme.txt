ALTER TABLE Orders
ADD FOREIGN KEY(CustomerId) REFERENCES Customers(Id);

Personid int IDENTITY(1,1) PRIMARY KEY,

Данные филтр, данные текст по столбцам

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
