namespace Зоомагазин
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.животноеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зоотоварыDataSet = new Зоомагазин.ЗоотоварыDataSet();
            this.товарTableAdapter = new Зоомагазин.ЗоотоварыDataSetTableAdapters.ТоварTableAdapter();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоотоварыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.брендDataGridViewTextBoxColumn,
            this.животноеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.составDataGridViewTextBoxColumn,
            this.единицаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.товарBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(23, 58);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1047, 469);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // брендDataGridViewTextBoxColumn
            // 
            this.брендDataGridViewTextBoxColumn.DataPropertyName = "Бренд";
            this.брендDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.брендDataGridViewTextBoxColumn.Name = "брендDataGridViewTextBoxColumn";
            this.брендDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // животноеDataGridViewTextBoxColumn
            // 
            this.животноеDataGridViewTextBoxColumn.DataPropertyName = "Животное";
            this.животноеDataGridViewTextBoxColumn.HeaderText = "Животное";
            this.животноеDataGridViewTextBoxColumn.Name = "животноеDataGridViewTextBoxColumn";
            this.животноеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // составDataGridViewTextBoxColumn
            // 
            this.составDataGridViewTextBoxColumn.DataPropertyName = "Состав";
            this.составDataGridViewTextBoxColumn.HeaderText = "Состав";
            this.составDataGridViewTextBoxColumn.Name = "составDataGridViewTextBoxColumn";
            this.составDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаDataGridViewTextBoxColumn
            // 
            this.единицаDataGridViewTextBoxColumn.DataPropertyName = "Единица";
            this.единицаDataGridViewTextBoxColumn.HeaderText = "Единица";
            this.единицаDataGridViewTextBoxColumn.Name = "единицаDataGridViewTextBoxColumn";
            this.единицаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.зоотоварыDataSet;
            // 
            // зоотоварыDataSet
            // 
            this.зоотоварыDataSet.DataSetName = "ЗоотоварыDataSet";
            this.зоотоварыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(828, 24);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(955, 22);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(105, 23);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Фильровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 558);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Доавить ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(955, 558);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(115, 23);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Личный кабинет";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(136, 558);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(247, 558);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(727, 24);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(81, 23);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(637, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(597, 20);
            this.textBoxSearch.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1088, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 593);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зоотоварыDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private ЗоотоварыDataSet зоотоварыDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ЗоотоварыDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn брендDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn животноеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn составDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonExit;
    }
}