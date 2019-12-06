namespace Coursa4TPI70
{
    partial class FormCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.издательствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсоваяТРПОDataSet = new Coursa4TPI70.КурсоваяТРПОDataSet();
            this.книгаTableAdapter = new Coursa4TPI70.КурсоваяТРПОDataSetTableAdapters.КнигаTableAdapter();
            this.BoxSearchBook = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonNalichie = new System.Windows.Forms.RadioButton();
            this.buttonSubscribe = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonSaveTable = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonAddSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяТРПОDataSet)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найти книгу по: названию,\r\nавтору, издательству, \r\nстоимости книги\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.стоимостьКнигиDataGridViewTextBoxColumn,
            this.издательствоDataGridViewTextBoxColumn,
            this.стоимостьИзданияDataGridViewTextBoxColumn,
            this.наличиеDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.книгаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 257);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            this.названиеКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьКнигиDataGridViewTextBoxColumn
            // 
            this.стоимостьКнигиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость книги";
            this.стоимостьКнигиDataGridViewTextBoxColumn.HeaderText = "Стоимость книги";
            this.стоимостьКнигиDataGridViewTextBoxColumn.Name = "стоимостьКнигиDataGridViewTextBoxColumn";
            this.стоимостьКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // издательствоDataGridViewTextBoxColumn
            // 
            this.издательствоDataGridViewTextBoxColumn.DataPropertyName = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.HeaderText = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.Name = "издательствоDataGridViewTextBoxColumn";
            this.издательствоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьИзданияDataGridViewTextBoxColumn
            // 
            this.стоимостьИзданияDataGridViewTextBoxColumn.DataPropertyName = "Стоимость издания";
            this.стоимостьИзданияDataGridViewTextBoxColumn.HeaderText = "Стоимость издания";
            this.стоимостьИзданияDataGridViewTextBoxColumn.Name = "стоимостьИзданияDataGridViewTextBoxColumn";
            this.стоимостьИзданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наличиеDataGridViewCheckBoxColumn
            // 
            this.наличиеDataGridViewCheckBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.Name = "наличиеDataGridViewCheckBoxColumn";
            this.наличиеDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // книгаBindingSource
            // 
            this.книгаBindingSource.DataMember = "Книга";
            this.книгаBindingSource.DataSource = this.курсоваяТРПОDataSet;
            // 
            // курсоваяТРПОDataSet
            // 
            this.курсоваяТРПОDataSet.DataSetName = "КурсоваяТРПОDataSet";
            this.курсоваяТРПОDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгаTableAdapter
            // 
            this.книгаTableAdapter.ClearBeforeFill = true;
            // 
            // BoxSearchBook
            // 
            this.BoxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BoxSearchBook.Location = new System.Drawing.Point(30, 359);
            this.BoxSearchBook.Multiline = true;
            this.BoxSearchBook.Name = "BoxSearchBook";
            this.BoxSearchBook.Size = new System.Drawing.Size(142, 36);
            this.BoxSearchBook.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(178, 357);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 40);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // radioButtonNalichie
            // 
            this.radioButtonNalichie.AutoCheck = false;
            this.radioButtonNalichie.AutoSize = true;
            this.radioButtonNalichie.Location = new System.Drawing.Point(15, 402);
            this.radioButtonNalichie.Name = "radioButtonNalichie";
            this.radioButtonNalichie.Size = new System.Drawing.Size(211, 21);
            this.radioButtonNalichie.TabIndex = 8;
            this.radioButtonNalichie.TabStop = true;
            this.radioButtonNalichie.Text = "Показать только в наличии";
            this.radioButtonNalichie.UseVisualStyleBackColor = true;
            this.radioButtonNalichie.CheckedChanged += new System.EventHandler(this.radioButtonNalichie_CheckedChanged);
            this.radioButtonNalichie.Click += new System.EventHandler(this.radioButtonNalichie_Click);
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.Location = new System.Drawing.Point(451, 349);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(87, 60);
            this.buttonSubscribe.TabIndex = 10;
            this.buttonSubscribe.Text = "Список подписок";
            this.buttonSubscribe.UseVisualStyleBackColor = true;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(6, 34);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(141, 45);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "Включить редактирование";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonSaveTable
            // 
            this.buttonSaveTable.Location = new System.Drawing.Point(153, 34);
            this.buttonSaveTable.Name = "buttonSaveTable";
            this.buttonSaveTable.Size = new System.Drawing.Size(141, 45);
            this.buttonSaveTable.TabIndex = 11;
            this.buttonSaveTable.Text = "Сохранить изменения";
            this.buttonSaveTable.UseVisualStyleBackColor = true;
            this.buttonSaveTable.Click += new System.EventHandler(this.buttonSaveTable_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.buttonSaveTable);
            this.groupBoxAdmin.Controls.Add(this.buttonAdmin);
            this.groupBoxAdmin.Location = new System.Drawing.Point(600, 330);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(299, 93);
            this.groupBoxAdmin.TabIndex = 12;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin - панель";
            this.groupBoxAdmin.Visible = false;
            // 
            // buttonAddSub
            // 
            this.buttonAddSub.Location = new System.Drawing.Point(284, 351);
            this.buttonAddSub.Name = "buttonAddSub";
            this.buttonAddSub.Size = new System.Drawing.Size(161, 58);
            this.buttonAddSub.TabIndex = 13;
            this.buttonAddSub.Text = "Добавить в подписки";
            this.buttonAddSub.UseVisualStyleBackColor = true;
            this.buttonAddSub.Click += new System.EventHandler(this.buttonAddSub_Click);
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 449);
            this.Controls.Add(this.buttonAddSub);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.buttonSubscribe);
            this.Controls.Add(this.radioButtonNalichie);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.BoxSearchBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCatalog_FormClosing);
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяТРПОDataSet)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private КурсоваяТРПОDataSet курсоваяТРПОDataSet;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private КурсоваяТРПОDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn издательствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьИзданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox BoxSearchBook;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonNalichie;
        private System.Windows.Forms.Button buttonSubscribe;
        private System.Windows.Forms.Button buttonSaveTable;
        private System.Windows.Forms.Button buttonAdmin;
        internal System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button buttonAddSub;
    }
}

