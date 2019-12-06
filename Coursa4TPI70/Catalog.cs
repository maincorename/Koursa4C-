using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursa4TPI70
{
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }

        private static string commandSelect = "SELECT * FROM Книга";
        private static string connectionParms = "Data Source=KOMPIBASTER;Initial Catalog=КурсоваяТРПО;Integrated Security=True";
        private SqlDataAdapter Adapter = new SqlDataAdapter(commandSelect, connectionParms);
        private DataTable dataTable = new DataTable();

        private void FormCatalog_Load(object sender, EventArgs e)
        {       
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(Adapter);

            Adapter.Fill(dataTable);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = dataTable;

            dataGridView1.DataSource = bSource;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BoxSearchBook.Text))
                {
                    MessageBox.Show("Не оставляйте поле пустым.");
                }
                else
                {    
                    dataGridView1.Refresh();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(BoxSearchBook.Text))
                                {
                                    dataGridView1.Rows[i].Selected = true;
                                    dataGridView1.FirstDisplayedScrollingRowIndex = i;
                                    MessageBox.Show(Convert.ToString(i));
                                    break;
                                }
                    }
                }
            }
            catch(Exception) { MessageBox.Show("Книга с заданными параметрами не в наличии."); }
        }

        private void radioButtonNalichie_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Refresh();

                if (radioButtonNalichie.Checked == true)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++) //показ книг только в наличии
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                dataGridView1.Rows[i].Visible = Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++) //показ всех книг, в наличии и нет
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
            catch(Exception) { }
        }

        private void radioButtonNalichie_Click(object sender, EventArgs e)
        {
            switch (radioButtonNalichie.Checked)
            {
                case true:
                    radioButtonNalichie.Checked = false;
                    break;
                case false:
                    radioButtonNalichie.Checked = true;
                    break;
            }
        }

        private void FormCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //запрет на выделение/редактирование, с возможностью просмотра списка
        {
            if (dataGridView1.ReadOnly == true)
            {
                if (MouseButtons != MouseButtons.None)
                    ((DataGridView)sender).CurrentCell = null;
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(dataGridView1.ReadOnly == true)
                ((DataGridView)sender).CurrentCell = null;
        }

        private void buttonSaveTable_Click(object sender, EventArgs e)
        {
            Adapter.Update(dataTable);
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            Subscribes sub = new Subscribes();
            sub.Owner = this;
            sub.ShowDialog();
        }

        private void buttonAddSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подписка добавлена.");

        }
    }
}
