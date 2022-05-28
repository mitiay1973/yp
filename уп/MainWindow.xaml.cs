using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace уп
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public int Admin;
        public MainWindow()
        {
            InitializeComponent();

        }
        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            string login_vx = login_vxod.Text;
            string password_vx = password_vxod.Password;
            if (login_vx != "") // проверяем введён ли логин     
            {
                if (password_vx != "" ) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    DataTable dt_user = Select("SELECT * FROM [dbo].[Users] WHERE [Login] = '" + login_vxod.Text + "' AND [password] = '" + password_vxod.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        DataTable dt_admin = Select("SELECT * FROM [dbo].[Admin] WHERE [Login] = '" + login_vxod.Text + "'");
                        if (dt_admin.Rows.Count > 0)
                        {
                            Admin = 1;
                        }
                        glavnaya glavnaya = new glavnaya();
                        if (Admin == 1)
                        {
                            glavnaya.Admin_panel.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            glavnaya.Admin_panel.Visibility = Visibility.Hidden;
                        }
                        this.Close();
                        DataTable dt_koll = Select("UPDATE [dbo].[Activ_user] SET [Login] ='" + login_vxod.Text + "' WHERE [Id_activ] = 1");
                        glavnaya.Show();
                    }
                    else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 
        }
        private void registration_Click(object sender, RoutedEventArgs e)
        {
            Registracia win = new Registracia();
            this.Close();
            win.Show();
            
        }
        private void login_vxod_TextChanged(object sender, TextChangedEventArgs e)
        {

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
