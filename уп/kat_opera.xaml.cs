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
using System.Windows.Shapes;
using уп;

namespace уп
{
    /// <summary>
    /// Логика взаимодействия для glavnaya.xaml
    /// </summary>
    public partial class kat_opera : Window
    {
        public string zagolovok = "";
        public Image[] image;
        public string[] opisanie;
        public string user = "";
        public int Admin;
        public kat_opera()
        {
            InitializeComponent();
        }

        private void katalog_Click(object sender, RoutedEventArgs e)
        {
            glavnaya glavnaya = new glavnaya();
            this.Close();
            glavnaya.Show();
            glavnaya.reklama.Visibility = Visibility.Hidden;
            glavnaya.label1.Visibility = Visibility.Visible;
            glavnaya.processori.Visibility = Visibility.Visible;
            glavnaya.mat_plati.Visibility = Visibility.Visible;
            glavnaya.videokarti.Visibility = Visibility.Visible;
            glavnaya.operativka.Visibility = Visibility.Visible;
            glavnaya.bloki_pit.Visibility = Visibility.Visible;
            glavnaya.korpusa.Visibility = Visibility.Visible;
            glavnaya.oxlad.Visibility = Visibility.Visible;
            glavnaya.ssd_hdd.Visibility = Visibility.Visible;
            glavnaya.label2.Visibility = Visibility.Visible;
            glavnaya.monitori.Visibility = Visibility.Visible;
            glavnaya.klaviatyri.Visibility = Visibility.Visible;
            glavnaya.mishi.Visibility = Visibility.Visible;
            glavnaya.veb_kameri.Visibility = Visibility.Visible;
            glavnaya.Nakopiteli_dannix.Visibility = Visibility.Visible;
            glavnaya.nayshniki.Visibility = Visibility.Visible;
            glavnaya.kabeli.Visibility = Visibility.Visible;
            glavnaya.kovriki.Visibility = Visibility.Visible;
            glavnaya.noutbuki.Visibility = Visibility.Visible;
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Login] FROM [dbo].[Activ_user] WHERE [Id_activ] = 1", connection);
                user = command.ExecuteScalar().ToString();
                DataTable dt_admin = Select("SELECT * FROM [dbo].[Admin] WHERE [Login] = '" + user + "'");
                if (dt_admin.Rows.Count > 0)
                {
                    Admin = 1;
                }
                if (Admin == 1)
                {
                    glavnaya.Admin_panel.Visibility = Visibility.Visible;
                }
                else
                {

                }
            }
        }
        private void kyp1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kyp2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kyp3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kyp4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kyp5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kyp6_Click(object sender, RoutedEventArgs e)
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
