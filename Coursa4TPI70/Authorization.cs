using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursa4TPI70
{
    public partial class Form1izd : Form
    {
        public Form1izd()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                Data.loginCh = textBoxLogin.Text;
                Data.passCh = textBoxPassword.Text;

                string connectionParms = "Data Source=KOMPIBASTER;Initial Catalog=КурсоваяТРПО;Integrated Security=True";
                string commandSqlCheck = $"SELECT COUNT(*) FROM Users WHERE login = '{Data.loginCh}' and password = '{Data.passCh}'";
                string commandADMCheck = "SELECT login FROM Users WHERE admin = 1";

                SqlConnection connect = new SqlConnection(connectionParms);
                SqlCommand check = new SqlCommand(commandSqlCheck, connect);
                SqlCommand ADMcheck = new SqlCommand(commandADMCheck, connect);

                connect.Open();
                check.Prepare();
                check.ExecuteNonQuery();

                int ch = (int)check.ExecuteScalar();

                if (ch == 1)
                {
                    FormCatalog catalog = new FormCatalog();

                    ADMcheck.Prepare();
                    ADMcheck.ExecuteNonQuery();

                    if (Data.loginCh == (string)ADMcheck.ExecuteScalar())
                    {
                        catalog.groupBoxAdmin.Visible = true;
                    }
                    connect.Close();

                    MessageBox.Show("Успешно.");

                    catalog.Show();
                    Hide();
                }
                else
                {
                    connect.Close();
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    MessageBox.Show("Введен неверный логин или пароль.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте снова");
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                Data.loginAdd = textBoxLogin.Text;
                Data.passAdd = textBoxPassword.Text;

                string connectionParms = "Data Source=KOMPIBASTER;Initial Catalog=КурсоваяТРПО;Integrated Security=True";
                string commandSqlAdd = $"Insert into Users(login, password) values('{Data.loginAdd}', '{Data.passAdd}')";
                string commandCheckLog = $"Select login from Users where login = '{Data.loginAdd}'";

                SqlConnection connect = new SqlConnection(connectionParms);
                SqlCommand add = new SqlCommand(commandSqlAdd, connect);
                SqlCommand checkLog = new SqlCommand(commandCheckLog, connect);

                connect.Open();
                checkLog.Prepare();
                checkLog.ExecuteNonQuery();

                if (Data.loginAdd == (string)checkLog.ExecuteScalar())
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    connect.Close();
                }
                else if(string.IsNullOrWhiteSpace(Data.loginAdd) || string.IsNullOrWhiteSpace(Data.passAdd))
                {
                    MessageBox.Show("Не оставляйте поле пустым");
                }
                else
                {
                    add.Prepare();
                    add.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Вы зарегистрировались.");
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте снова");
            }
        }
    }
}
