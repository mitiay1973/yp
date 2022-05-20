using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace уп
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Registracia : Window
    {
        public string login = "";
        public string password = "";
        public string password1 = "";
        public Registracia()
        {
            InitializeComponent();
        }

        private void login_reg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void zaregistrirovatsia_Click(object sender, RoutedEventArgs e)
        {
            login = login_reg.Text;
            password = password_reg.Password;
            password1 = password_reg_Copy.Password;
            if(login == "")
            {
                MessageBox.Show("Введите логин");
            }
            else
            {
                if (password == "")
                {
                    MessageBox.Show("Введите пароль");
                }
                else
                {
                    if (password1 == "")
                    {
                        MessageBox.Show("Повторите пароль");
                    }
                    else
                    {
                        if(password != password1)
                        {
                            MessageBox.Show("Проверьте правильность ввода пароля");
                        }
                        else
                        {
                            DataTable dt_user1 = Select("SELECT * FROM [dbo].[Users] WHERE [Login] = '" + login_reg.Text + "' AND [password] = '" + login_reg.Text + "'");
                            if (dt_user1.Rows.Count > 0) // если такая запись существует       
                            {
                                MessageBox.Show("Регистрация успешно завершена");
                                DataTable dt_user = Select("insert into [dbo].[Users] ([Login], [password]) values('" + login_reg.Text + "','" + password_reg.Password + "')");
                                MainWindow win_gl = new MainWindow();
                                this.Close();
                                win_gl.Show();
                            }
                            else
                            {
                                MessageBox.Show("Такой аккаунт уже существует");
                            }
                        }
                    }
                }
            }
        }
        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase"); // создаём таблицу в приложении
                                                             // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357");
            sqlConnection.Open(); // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand(); // создаём команду
            sqlCommand.CommandText = selectSQL; // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close(); // возращаем таблицу с результатом
            return dataTable;
        }
    }
}
