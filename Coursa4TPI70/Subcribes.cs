using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursa4TPI70
{
    public partial class Subscribes : Form
    {
        public Subscribes()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(connectionParms);
        static string connectionParms = "Data Source = KOMPIBASTER; Initial Catalog = КурсоваяТРПО; Integrated Security = True";

        private void Subscribes_Load(object sender, EventArgs e)
        {
            connection.Open();

            string commandSelect = $"SELECT id FROM Users " +
            $"WHERE login = '{Data.loginCh}'";

            SqlCommand commandFindUser = new SqlCommand(commandSelect, connection);
            commandFindUser.Prepare();
            commandFindUser.ExecuteNonQuery();
            Data.idUser = (int)commandFindUser.ExecuteScalar();

            string commandSelectIDBook = $"SELECT [Название книги], Оплачено, Отправлено FROM Subscribes, Книга " +
            $"WHERE id_user = '{Data.idUser}' AND id_book = id_книга";

            SqlCommand SqlComSelectIDBook = new SqlCommand(commandSelectIDBook, connection);
            SqlDataAdapter Adapter = new SqlDataAdapter(commandSelectIDBook, connectionParms);

            DataTable dataTable = new DataTable();
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(Adapter);

            Adapter.Fill(dataTable);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = dataTable;
            dataGridView1.DataSource = bSource;

            connection.Close();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
                ((DataGridView)sender).CurrentCell = null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (MouseButtons != MouseButtons.None)
                ((DataGridView)sender).CurrentCell = null;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            connection.Open();

            string commandSell = $"SELECT [Стоимость издания] FROM Книга, Subscribes " +
            $"WHERE id_book = id_книга AND id_user = '{Data.idUser}' AND Оплачено = 0";

            SqlCommand SqlComSell = new SqlCommand(commandSell, connection);

            string commandSellUpdate = "UPDATE Subscribes SET Оплачено = 1 " +
            "WHERE Оплачено = 0";

            SqlCommand SqlComUpdate = new SqlCommand(commandSellUpdate, connection);

            SqlComSell.Prepare();
            SqlComSell.ExecuteNonQuery();

            MessageBox.Show($"К оплате {Convert.ToDouble(SqlComSell.ExecuteScalar())} рублей, с учётом доставки");
            
            SqlComUpdate.Prepare();
            SqlComUpdate.ExecuteNonQuery();

            connection.Close();
        }

        private void buttonDeleteSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Нечего удалять");
            }
            else MessageBox.Show("Подписка удалена");
        }
    }
}
