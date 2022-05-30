using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    public partial class adminka : Window
    {

        public adminka()
        {
            InitializeComponent();
            LoadBarChartData();
        }
        private void LoadBarChartData()
        {
            DataTable dt_kol1 = Select("SELECT * FROM [dbo].[Users]");
            int kol = dt_kol1.Rows.Count;
            int[] kol1 = new int[kol+1];
            string[] log = new string[kol+1];
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                for (int i = 1; i <= kol; i++)
                {
                    SqlCommand command = new SqlCommand("SELECT [Login] FROM [dbo].[Users] WHERE [id_user]='" + i + "'", connection);
                    log[i] = command.ExecuteScalar().ToString();
                    DataTable dt_kol = Select("SELECT * FROM [dbo].[Zakaz] WHERE [Login]= '" + log[i] + "'");
                    if (dt_kol.Rows.Count > 0)
                    {
                        kol1[i] = dt_kol.Rows.Count;
                    }
                    else
                    {
                        kol1[i] = 0;
                    }

                    ((ColumnSeries)mcChart.Series[0]).ItemsSource =
                     new KeyValuePair<string, int>[]
                    {
                    new KeyValuePair<string, int>(log[1], kol1[1]),
                    new KeyValuePair<string, int>(log[2], kol1[2]),
                    new KeyValuePair<string, int>(log[3], kol1[3]),
                    new KeyValuePair<string, int>(log[4], kol1[4])
                    };
                }
            }
        }



        private void katalog_Click(object sender, RoutedEventArgs e)
        {
            glavnaya glavnaya = new glavnaya();
            this.Close();
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
