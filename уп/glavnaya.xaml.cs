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
    public partial class glavnaya : Window
    {
        public glavnaya()
        {
            InitializeComponent();
            label1.Visibility = Visibility.Hidden;
            processori.Visibility = Visibility.Hidden;
            mat_plati.Visibility = Visibility.Hidden;
            videokarti.Visibility = Visibility.Hidden;
            operativka.Visibility = Visibility.Hidden;
            bloki_pit.Visibility = Visibility.Hidden;
            korpusa.Visibility = Visibility.Hidden;
            oxlad.Visibility = Visibility.Hidden;
            ssd_hdd.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            monitori.Visibility = Visibility.Hidden;
            klaviatyri.Visibility = Visibility.Hidden;
            mishi.Visibility = Visibility.Hidden;
            veb_kameri.Visibility = Visibility.Hidden;
            Nakopiteli_dannix.Visibility = Visibility.Hidden;
            nayshniki.Visibility = Visibility.Hidden;
            kabeli.Visibility = Visibility.Hidden;
            kovriki.Visibility = Visibility.Hidden;
            noutbuki.Visibility = Visibility.Hidden;
            if (Admin_panel.IsVisible == true)
            {
                Admin_panel.Visibility = Visibility.Visible;
            }
            else
            {

            }
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void glavniy_Click(object sender, RoutedEventArgs e)
        {
            reklama.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Hidden;
            processori.Visibility = Visibility.Hidden;
            mat_plati.Visibility = Visibility.Hidden;
            videokarti.Visibility = Visibility.Hidden;
            operativka.Visibility = Visibility.Hidden;
            bloki_pit.Visibility = Visibility.Hidden;
            korpusa.Visibility = Visibility.Hidden;
            oxlad.Visibility = Visibility.Hidden;
            ssd_hdd.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            monitori.Visibility = Visibility.Hidden;
            klaviatyri.Visibility = Visibility.Hidden;
            mishi.Visibility = Visibility.Hidden;
            veb_kameri.Visibility = Visibility.Hidden;
            Nakopiteli_dannix.Visibility = Visibility.Hidden;
            nayshniki.Visibility = Visibility.Hidden;
            kabeli.Visibility = Visibility.Hidden;
            kovriki.Visibility = Visibility.Hidden;
            noutbuki.Visibility = Visibility.Hidden;
            if (Admin_panel.IsVisible == true)
            {
                Admin_panel.Visibility = Visibility.Visible;
            }
            else
            {

            }
        }

        private void katalog_Click(object sender, RoutedEventArgs e)
        {
            reklama.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Visible;
            processori.Visibility = Visibility.Visible;
            mat_plati.Visibility = Visibility.Visible;
            videokarti.Visibility = Visibility.Visible;
            operativka.Visibility = Visibility.Visible;
            bloki_pit.Visibility = Visibility.Visible;
            korpusa.Visibility = Visibility.Visible;
            oxlad.Visibility = Visibility.Visible;
            ssd_hdd.Visibility = Visibility.Visible;
            label2.Visibility = Visibility.Visible;
            monitori.Visibility = Visibility.Visible;
            klaviatyri.Visibility = Visibility.Visible;
            mishi.Visibility = Visibility.Visible;
            veb_kameri.Visibility = Visibility.Visible;
            Nakopiteli_dannix.Visibility = Visibility.Visible;
            nayshniki.Visibility = Visibility.Visible;
            kabeli.Visibility = Visibility.Visible;
            kovriki.Visibility = Visibility.Visible;
            noutbuki.Visibility = Visibility.Visible;
            if (Admin_panel.IsVisible == true)
            {
                Admin_panel.Visibility = Visibility.Visible;
            }
            else
            {

            }
        }
        private void processori_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            katalog win_proc = new katalog();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_proc.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_proc.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_proc.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_proc.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_proc.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Сокет {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Сокет {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Сокет {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Сокет {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Сокет {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Сокет {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Число ядер {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Число ядер {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Число ядер {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Число ядер {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Число ядер {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Число ядер {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Число потоков {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Число потоков {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Число потоков {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Число потоков {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Число потоков {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Число потоков {opisanie[5]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_proc.Show();
            win_proc.kyp1.Click += Kyp1_Click;
            win_proc.kyp2.Click += Kyp2_Click;
            win_proc.kyp3.Click += Kyp3_Click;
            win_proc.kyp4.Click += Kyp4_Click;
            win_proc.kyp5.Click += Kyp5_Click;
            win_proc.kyp6.Click += Kyp6_Click;

        }

        private void Kyp6_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            int koll;
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                koll= Convert.ToInt32(commandddddd.ExecuteScalar().ToString());
                win_proc.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr6.Text;
            kor.oform.Click += Oform_Click;

            }

        private void Kyp5_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp4_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp3_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp2_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp1_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_procesor] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_proc.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Coket] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Chislo_yader] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Число ядер {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Chislo_potokov] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Число потоков {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_proc.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Procesor] WHERE [Id_procesor] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_proc.pr1.Text;
            kor.oform.Click += Oform_Click;

        }

        private void Oform_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mat_plati_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_mat_plat win_mat = new kat_mat_plat();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_mat.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_mat.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_mat.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_mat.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_mat.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Форм-фактор {opisanie[0]}, ";
                SqlCommand commandd1 = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Форм-фактор {opisanie[1]}, ";
                SqlCommand commandd2 = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Форм-фактор {opisanie[2]}, ";
                SqlCommand commandd3 = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Форм-фактор {opisanie[3]}, ";
                SqlCommand commandd4 = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Форм-фактор {opisanie[4]}, ";
                SqlCommand commandd5 = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Форм-фактор {opisanie[5]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Сокет {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Сокет {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Сокет {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Сокет {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Сокет {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Сокет {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Чипсет {opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Чипсет {opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Чипсет {opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Чипсет {opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Чипсет {opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Чипсет {opisanie[5]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Количество памяти {opisanie[0]}, \n";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Количество памяти {opisanie[1]}, \n";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Количество памяти {opisanie[2]}, \n";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Количество памяти {opisanie[3]}, \n";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Количество памяти {opisanie[4]}, \n";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Количество памяти {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_mat.Show();
            win_mat.kyp1.Click += Kyp7_Click;
            win_mat.kyp2.Click += Kyp8_Click;
            win_mat.kyp3.Click += Kyp9_Click;
            win_mat.kyp4.Click += Kyp10_Click;
            win_mat.kyp5.Click += Kyp11_Click;
            win_mat.kyp6.Click += Kyp12_Click;
        }
        private void Kyp7_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp8_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp9_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp10_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp11_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp12_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Mat_plat] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mat.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Form_factor] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Форм-фактор {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Coket] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Сокет {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [ChipSet] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Чипсет {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolvo_pamati] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Количество памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mat.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mat_plat] WHERE [Id_Mat_plat] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mat.pr6.Text;
            kor.oform.Click += Oform_Click;

        }
        private void videokarti_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_videokart win_videokart = new kat_videokart();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_videokart.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_videokart.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_videokart.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_videokart.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_videokart.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Частота ядра {opisanie[0]}, ";
                SqlCommand commandd1 = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Частота ядра {opisanie[1]}, ";
                SqlCommand commandd2 = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Частота ядра {opisanie[2]}, ";
                SqlCommand commandd3 = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Частота ядра {opisanie[3]}, ";
                SqlCommand commandd4 = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Частота ядра {opisanie[4]}, ";
                SqlCommand commandd5 = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Частота ядра {opisanie[5]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Тип памяти {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Тип памяти {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Тип памяти {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Тип памяти {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Тип памяти {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Тип памяти {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Объем памяти {opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Объем памяти {opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Объем памяти {opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Объем памяти {opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Объем памяти {opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Объем памяти {opisanie[5]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_videokart.Show();
            win_videokart.kyp1.Click += Kyp13_Click;
            win_videokart.kyp2.Click += Kyp14_Click;
            win_videokart.kyp3.Click += Kyp15_Click;
            win_videokart.kyp4.Click += Kyp16_Click;
            win_videokart.kyp5.Click += Kyp17_Click;
            win_videokart.kyp6.Click += Kyp18_Click;
        }


        private void Kyp13_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp14_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp15_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp16_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp17_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp18_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_videocart] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_videokart.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Castota_yadra] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Частота ядра {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Тип памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Obem_pamati] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Объем памяти {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_videokart.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Videocart] WHERE [Id_videocart] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_videokart.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void operativka_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_opera win_opera = new kat_opera();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_opera.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_opera.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_opera.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_opera.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_opera.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Тип памяти {opisanie[0]}, ";
                SqlCommand commandd1 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Тип памяти {opisanie[1]}, ";
                SqlCommand commandd2 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Тип памяти {opisanie[2]}, ";
                SqlCommand commandd3 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Тип памяти {opisanie[3]}, ";
                SqlCommand commandd4 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Тип памяти {opisanie[4]}, ";
                SqlCommand commandd5 = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Тип памяти {opisanie[5]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Частота {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Частота {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Частота {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Частота {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Частота {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Частота {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Объем {opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Объем {opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Объем {opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Объем {opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Объем {opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Объем {opisanie[5]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Количество плашек {opisanie[0]}, \n";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Количество плашек {opisanie[1]}, \n";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Количество плашек {opisanie[2]}, \n";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Количество плашек {opisanie[3]}, \n";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Количество плашек {opisanie[4]}, \n";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Количество плашек {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_opera.Show();
            win_opera.kyp1.Click += Kyp19_Click;
            win_opera.kyp2.Click += Kyp20_Click;
            win_opera.kyp3.Click += Kyp21_Click;
            win_opera.kyp4.Click += Kyp22_Click;
            win_opera.kyp5.Click += Kyp23_Click;
            win_opera.kyp6.Click += Kyp24_Click;
        }

        private void Kyp19_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp20_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp21_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp22_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp23_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp24_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Operativ_pamat] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_opera.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tip_pamati] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Тип памяти {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Chastota] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Частота {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [obem] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Объем {opisanie[0]}, ";

                SqlCommand commanddddd = new SqlCommand("SELECT [Kolishestvo_plashek] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Количество плашек {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_opera.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Operativka] WHERE [Id_Operativ_pamat] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_opera.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void bloki_pit_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_bloki win_bloki = new kat_bloki();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_bloki.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_bloki.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_bloki.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_bloki.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_bloki.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Форм-фактор {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Форм-фактор {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Форм-фактор {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Форм-фактор {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Форм-фактор {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Форм-фактор {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Мощность {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Мощность {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Мощность {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Мощность {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Мощность {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Мощность {opisanie[5]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_bloki.Show();
            win_bloki.kyp1.Click += Kyp25_Click;
            win_bloki.kyp2.Click += Kyp26_Click;
            win_bloki.kyp3.Click += Kyp27_Click;
            win_bloki.kyp4.Click += Kyp28_Click;
            win_bloki.kyp5.Click += Kyp29_Click;
            win_bloki.kyp6.Click += Kyp30_Click;
        }

        private void Kyp25_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp26_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp27_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp28_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp29_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp30_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_Blok_pitanie] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_bloki.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Form_Factor] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Мощность {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_bloki.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Blok_pitanie] WHERE [Id_Blok_pitanie] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_bloki.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void korpusa_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_korpusa win_korp = new kat_korpusa();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_korp.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_korp.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_korp.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_korp.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_korp.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Типоразмер {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Типоразмер {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Типоразмер {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Типоразмер {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Типоразмер {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Типоразмер {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Форм-фактор {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Форм-фактор {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Форм-фактор {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Форм-фактор {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Форм-фактор {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Форм-фактор {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_korp.Show();
            win_korp.kyp1.Click += Kyp31_Click;
            win_korp.kyp2.Click += Kyp32_Click;
            win_korp.kyp3.Click += Kyp33_Click;
            win_korp.kyp4.Click += Kyp34_Click;
            win_korp.kyp5.Click += Kyp35_Click;
            win_korp.kyp6.Click += Kyp36_Click;
        }

        private void Kyp31_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp32_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp33_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp34_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp35_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp36_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Nazvanie] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_korp.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Tiporazmer] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Типоразмер {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [FormFactor] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Форм-фактор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_korp.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Korpusa] WHERE [Id_korpusa] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_korp.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void oxlad_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_oxlad win_oxl = new kat_oxlad();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_oxl.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_oxl.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_oxl.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_oxl.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_oxl.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Оборотов/мин {opisanie[0]}, ";
                SqlCommand commandd1 = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Оборотов/мин {opisanie[1]}, ";
                SqlCommand commandd2 = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Оборотов/мин {opisanie[2]}, ";
                SqlCommand commandd3 = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Оборотов/мин {opisanie[3]}, ";
                SqlCommand commandd4 = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Оборотов/мин {opisanie[4]}, ";
                SqlCommand commandd5 = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Оборотов/мин {opisanie[5]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Мощность {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Мощность {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Мощность {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Мощность {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Мощность {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Мощность {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_oxl.Show();
            win_oxl.kyp1.Click += Kyp37_Click;
            win_oxl.kyp2.Click += Kyp38_Click;
            win_oxl.kyp3.Click += Kyp39_Click;
            win_oxl.kyp4.Click += Kyp40_Click;
            win_oxl.kyp5.Click += Kyp41_Click;
            win_oxl.kyp6.Click += Kyp42_Click;
        }

        private void Kyp37_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp38_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp39_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp40_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp41_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp42_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_oxlad] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_oxl.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Oborotov/min] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Оборотов/мин {opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Power] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Мощность {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_oxl.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Oxladd] WHERE [Id_oxlad] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_oxl.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void ssd_hdd_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_ssd win_ssd = new kat_ssd();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_ssd.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_ssd.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_ssd.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_ssd.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_ssd.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Объем {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Объем {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Объем {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Объем {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Объем {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Объем {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Скорость чтения {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Скорость чтения {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Скорость чтения {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Скорость чтения {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Скорость чтения {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Скорость чтения {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Скорость записи {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Скорость записи {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Скорость записи {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Скорость записи {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Скорость записи {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Скорость записи {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_ssd.Show();
            win_ssd.kyp1.Click += Kyp43_Click;
            win_ssd.kyp2.Click += Kyp44_Click;
            win_ssd.kyp3.Click += Kyp45_Click;
            win_ssd.kyp4.Click += Kyp46_Click;
            win_ssd.kyp5.Click += Kyp47_Click;
            win_ssd.kyp6.Click += Kyp48_Click;
        }

        private void Kyp43_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp44_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp45_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp46_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp47_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp48_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Name_SSD_HDD] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_ssd.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [volume] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [reading_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Скорость чтения {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [write_speed] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Скорость записи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolishestvo] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_ssd.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Ssd_and_Hdd] WHERE [Id_SSD_HDD] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_ssd.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void monitori_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_monitori win_monitor = new kat_monitori();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_monitor.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_monitor.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_monitor.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_monitor.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_monitor.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Разрешение {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Разрешение {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Разрешение {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Разрешение {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Разрешение {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Разрешение {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Коннектор {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Коннектор {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Коннектор {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Коннектор {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Коннектор {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Коннектор {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Матрица {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Матрица {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Матрица {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Матрица {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Матрица {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Матрица {opisanie[5]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Частота обновления {opisanie[0]}, ";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Частота обновления {opisanie[1]}, ";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Частота обновления {opisanie[2]}, ";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Частота обновления {opisanie[3]}, ";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Частота обновления {opisanie[4]}, ";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Частота обновления {opisanie[5]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_monitor.Show();
            win_monitor.kyp1.Click += Kyp49_Click;
            win_monitor.kyp2.Click += Kyp50_Click;
            win_monitor.kyp3.Click += Kyp51_Click;
            win_monitor.kyp4.Click += Kyp52_Click;
            win_monitor.kyp5.Click += Kyp53_Click;
            win_monitor.kyp6.Click += Kyp54_Click;
        }

        private void Kyp49_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp50_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp51_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp52_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp53_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp54_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_monitor.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Resolution] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Разрешение {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Коннектор {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Matrix] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Матрица {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Hz] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Частота обновления {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_monitor.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Monitors] WHERE [Id_monitors] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_monitor.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void klaviatyri_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_klaviaturi win_klav = new kat_klaviaturi();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_klav.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_klav.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_klav.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_klav.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_klav.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Тип {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Тип {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Тип {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Тип {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Тип {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Тип {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Материал {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Материал {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Материал {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Материал {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Материал {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Материал {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Формат {opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Формат {opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Формат {opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Формат {opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Формат {opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Формат {opisanie[5]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_klav.Show();
            win_klav.kyp1.Click += Kyp55_Click;
            win_klav.kyp2.Click += Kyp56_Click;
            win_klav.kyp3.Click += Kyp57_Click;
            win_klav.kyp4.Click += Kyp58_Click;
            win_klav.kyp5.Click += Kyp59_Click;
            win_klav.kyp6.Click += Kyp60_Click;
        }

        private void Kyp55_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp56_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp57_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp58_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp59_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp60_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_klav.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Материал {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Format] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Формат {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_klav.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Klaviatyra] WHERE [id_klaviatyra] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_klav.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void mishi_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_mishi win_mish = new kat_mishi();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_mish.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_mish.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_mish.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_mish.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_mish.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"DPI {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"DPI {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"DPI {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"DPI {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"DPI {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"DPI {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Коннектор {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Коннектор {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Коннектор {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Коннектор {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Коннектор {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Коннектор {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_mish.Show();
            win_mish.kyp1.Click += Kyp61_Click;
            win_mish.kyp2.Click += Kyp62_Click;
            win_mish.kyp3.Click += Kyp63_Click;
            win_mish.kyp4.Click += Kyp64_Click;
            win_mish.kyp5.Click += Kyp65_Click;
            win_mish.kyp6.Click += Kyp66_Click;
        }

        private void Kyp61_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp62_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp63_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp64_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp65_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp66_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_mish.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [DPI] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"DPI {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connector] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Коннектор {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_mish.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Mouse] WHERE [id_mouse] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_mish.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void veb_kameri_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_veb_cam win_veb = new kat_veb_cam();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_veb.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_veb.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_veb.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_veb.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_veb.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Кадров в секунду {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Кадров в секунду {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Кадров в секунду {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Кадров в секунду {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Кадров в секунду {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Кадров в секунду {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Разрешение {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Разрешение {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Разрешение {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Разрешение {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Разрешение {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Разрешение {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Тип матрицы {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Тип матрицы {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Тип матрицы {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Тип матрицы {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Тип матрицы {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Тип матрицы {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_veb.Show();
            win_veb.kyp1.Click += Kyp67_Click;
            win_veb.kyp2.Click += Kyp68_Click;
            win_veb.kyp3.Click += Kyp69_Click;
            win_veb.kyp4.Click += Kyp70_Click;
            win_veb.kyp5.Click += Kyp71_Click;
            win_veb.kyp6.Click += Kyp72_Click;
        }

        private void Kyp67_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp68_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp69_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp70_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp71_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp72_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_veb.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Fps] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Кадров в секунду {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Rezolution] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Разрешение {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Tip_matrizi] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Тип матрицы {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_veb.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Veb_camera] WHERE [id_Veb_camera] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_veb.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Nakopiteli_dannix_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_dannie win_dannie = new kat_dannie();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_dannie.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_dannie.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_dannie.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_dannie.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_dannie.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Объем {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Объем {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Объем {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Объем {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Объем {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Объем {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Разъем {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Разъем {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Разъем {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Разъем {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Разъем {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Разъем {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Скорость зап {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Скорость зап {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Скорость зап {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Скорость зап {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Скорость зап {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Скорость зап {opisanie[5]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Скорость чт {opisanie[0]}, ";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Скорость чт {opisanie[1]}, ";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Скорость чт {opisanie[2]}, ";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Скорость чт {opisanie[3]}, ";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Скорость чт {opisanie[4]}, ";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Скорость чт {opisanie[5]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_dannie.Show();
            win_dannie.kyp1.Click += Kyp73_Click;
            win_dannie.kyp2.Click += Kyp74_Click;
            win_dannie.kyp3.Click += Kyp75_Click;
            win_dannie.kyp4.Click += Kyp76_Click;
            win_dannie.kyp5.Click += Kyp77_Click;
            win_dannie.kyp6.Click += Kyp78_Click;
        }

        private void Kyp73_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp74_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp75_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp76_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp77_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp78_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_dannie.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Volume] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Объем {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Connect] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Разъем {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Write_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Скорость зап {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Read_speed] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Скорость чт {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_dannie.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Vneshnie_nakopiteli] WHERE [id_vneshnie_nakopiteli] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_dannie.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void nayshniki_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_naysh win_naysh = new kat_naysh();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr1.Text = $"{opisanie[0]}, ";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_naysh.pr2.Text = $"{opisanie[1]}, ";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_naysh.pr3.Text = $"{opisanie[2]}, ";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_naysh.pr4.Text = $"{opisanie[3]}, ";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_naysh.pr5.Text = $"{opisanie[4]}, ";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_naysh.pr6.Text = $"{opisanie[5]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Тип {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Тип {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Тип {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Тип {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Тип {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Тип {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Длина {opisanie[0]}, ";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Длина {opisanie[1]}, ";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Длина {opisanie[2]}, ";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Длина {opisanie[3]}, ";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Длина {opisanie[4]}, ";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Длина {opisanie[5]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Вид передачи {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Вид передачи {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Вид передачи {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Вид передачи {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Вид передачи {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Вид передачи {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_naysh.Show();
            win_naysh.kyp1.Click += Kyp79_Click;
            win_naysh.kyp2.Click += Kyp80_Click;
            win_naysh.kyp3.Click += Kyp81_Click;
            win_naysh.kyp4.Click += Kyp82_Click;
            win_naysh.kyp5.Click += Kyp83_Click;
            win_naysh.kyp6.Click += Kyp84_Click;
        }

        private void Kyp79_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr1.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp80_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr2.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp81_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr3.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp82_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr4.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp83_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr5.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp84_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_naysh.pr6.Text = $"{opisanie[0]}, ";

                SqlCommand commandd = new SqlCommand("SELECT [Tip] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Тип {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Длина {opisanie[0]}, ";

                SqlCommand commandddd = new SqlCommand("SELECT [Vid_peredachi] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Вид передачи {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_naysh.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Nayshniki] WHERE [id_nayshniki] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_naysh.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void kabeli_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_kabeli win_kabeli = new kat_kabeli();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"{opisanie[0]} - ";
                SqlCommand commandd1 = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"{opisanie[1]} - ";
                SqlCommand commandd2 = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"{opisanie[2]} - ";
                SqlCommand commandd3 = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"{opisanie[3]} - ";
                SqlCommand commandd4 = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"{opisanie[4]} - ";
                SqlCommand commandd5 = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"{opisanie[5]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"{opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"{opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"{opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"{opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"{opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"{opisanie[5]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Длина {opisanie[0]}м, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Длина {opisanie[1]}м, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Длина {opisanie[2]}м, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Длина {opisanie[3]}м, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Длина {opisanie[4]}м,\n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Длина {opisanie[5]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_kabeli.Show();
            win_kabeli.kyp1.Click += Kyp85_Click;
            win_kabeli.kyp2.Click += Kyp86_Click;
            win_kabeli.kyp3.Click += Kyp87_Click;
            win_kabeli.kyp4.Click += Kyp88_Click;
            win_kabeli.kyp5.Click += Kyp89_Click;
            win_kabeli.kyp6.Click += Kyp90_Click;
        }
        private void Kyp85_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp86_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp87_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp88_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp89_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp90_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kabeli.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Connector_1] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"{opisanie[0]} - ";

                SqlCommand commandddd = new SqlCommand("SELECT [Connector_2] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"{opisanie[0]}, ";

                SqlCommand commanddd = new SqlCommand("SELECT [Dlina(M)] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Длина {opisanie[0]}м, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kabeli.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kabeli] WHERE [id_kabeli] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr6.Text;
            kor.oform.Click += Oform_Click;
        }
        private void kovriki_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_kovriki win_kovriki = new kat_kovriki();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Материал покрытия {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Материал покрытия {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Материал покрытия {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Материал покрытия {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Материал покрытия {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Материал покрытия {opisanie[5]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Материал основания {opisanie[0]}, \n";
                SqlCommand commanddd1 = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = commanddd1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Материал основания {opisanie[1]}, \n";
                SqlCommand commanddd2 = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = commanddd2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Материал основания {opisanie[2]}, \n";
                SqlCommand commanddd3 = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = commanddd3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Материал основания {opisanie[3]}, \n";
                SqlCommand commanddd4 = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = commanddd4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Материал основания {opisanie[4]}, \n";
                SqlCommand commanddd5 = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = commanddd5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Материал основания {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Размер {opisanie[0]}, ";
                SqlCommand commandddd1 = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Размер {opisanie[1]}, ";
                SqlCommand commandddd2 = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Размер {opisanie[2]}, ";
                SqlCommand commandddd3 = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Размер {opisanie[3]}, ";
                SqlCommand commandddd4 = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Размер {opisanie[4]}, ";
                SqlCommand commandddd5 = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Размер {opisanie[5]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Цена {opisanie[0]}, \n";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Цена {opisanie[1]}, \n";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Цена {opisanie[2]}, \n";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Цена {opisanie[3]}, \n";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Цена {opisanie[4]}, \n";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Цена {opisanie[5]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_kovriki.Show();
            win_kovriki.kyp1.Click += Kyp91_Click;
            win_kovriki.kyp2.Click += Kyp92_Click;
            win_kovriki.kyp3.Click += Kyp93_Click;
            win_kovriki.kyp4.Click += Kyp94_Click;
            win_kovriki.kyp5.Click += Kyp95_Click;
            win_kovriki.kyp6.Click += Kyp96_Click;
        }

        private void Kyp91_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp92_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp93_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp94_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp95_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp96_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_kovriki.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Material_pokritia] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Материал покрытия {opisanie[0]}, \n";

                SqlCommand commanddd = new SqlCommand("SELECT [Material_ocnovania] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = commanddd.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Материал основания {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [Razmer] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Размер {opisanie[0]}, ";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Цена {opisanie[0]}, \n";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichestvo] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_kovriki.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Kovriki] WHERE [id_kovriki] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void noutbuki_Click(object sender, RoutedEventArgs e)
        {
            string[] opisanie = new string[6];
            kat_noytbuki win_nout = new kat_noytbuki();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr1.Text = $"{opisanie[0]}, \n";
                SqlCommand command1 = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = command1.ExecuteScalar().ToString();
                win_nout.pr2.Text = $"{opisanie[1]}, \n";
                SqlCommand command2 = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = command2.ExecuteScalar().ToString();
                win_nout.pr3.Text = $"{opisanie[2]}, \n";
                SqlCommand command3 = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = command3.ExecuteScalar().ToString();
                win_nout.pr4.Text = $"{opisanie[3]}, \n";
                SqlCommand command4 = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = command4.ExecuteScalar().ToString();
                win_nout.pr5.Text = $"{opisanie[4]}, \n";
                SqlCommand command5 = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = command5.ExecuteScalar().ToString();
                win_nout.pr6.Text = $"{opisanie[5]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Объем оперативной памяти {opisanie[0]}, \n";
                SqlCommand commandd1 = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = commandd1.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Объем оперативной памяти {opisanie[1]}, \n";
                SqlCommand commandd2 = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = commandd2.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Объем оперативной памяти {opisanie[2]}, \n";
                SqlCommand commandd3 = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = commandd3.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Объем оперативной памяти {opisanie[3]}, \n";
                SqlCommand commandd4 = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = commandd4.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Объем оперативной памяти {opisanie[4]}, \n";
                SqlCommand commandd5 = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = commandd5.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Объем оперативной памяти {opisanie[5]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Процессор {opisanie[0]}, \n";
                SqlCommand commandddd1 = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = commandddd1.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Процессор {opisanie[1]}, \n";
                SqlCommand commandddd2 = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = commandddd2.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Процессор {opisanie[2]}, \n";
                SqlCommand commandddd3 = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = commandddd3.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Процессор {opisanie[3]}, \n";
                SqlCommand commandddd4 = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = commandddd4.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Процессор {opisanie[4]}, \n";
                SqlCommand commandddd5 = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = commandddd5.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Процессор {opisanie[5]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Объем памяти {opisanie[0]}, \n";
                SqlCommand commanddddd1 = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = commanddddd1.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Объем памяти {opisanie[1]}, \n";
                SqlCommand commanddddd2 = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = commanddddd2.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Объем памяти {opisanie[2]}, \n";
                SqlCommand commanddddd3 = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = commanddddd3.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Объем памяти {opisanie[3]}, \n";
                SqlCommand commanddddd4 = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = commanddddd4.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Объем памяти {opisanie[4]}, \n";
                SqlCommand commanddddd5 = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = commanddddd5.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Объем памяти {opisanie[5]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Цена {opisanie[0]}, ";
                SqlCommand commanddddddd1 = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = commanddddddd1.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Цена {opisanie[1]}, ";
                SqlCommand commanddddddd2 = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = commanddddddd2.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Цена {opisanie[2]}, ";
                SqlCommand commanddddddd3 = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = commanddddddd3.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Цена {opisanie[3]}, ";
                SqlCommand commanddddddd4 = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = commanddddddd4.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Цена {opisanie[4]}, ";
                SqlCommand commanddddddd5 = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = commanddddddd5.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Цена {opisanie[5]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Количество на складе {opisanie[0]} ";
                SqlCommand commandddddd1 = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[1] = commandddddd1.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Количество на складе {opisanie[1]} ";
                SqlCommand commandddddd2 = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[2] = commandddddd2.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Количество на складе {opisanie[2]} ";
                SqlCommand commandddddd3 = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[3] = commandddddd3.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Количество на складе {opisanie[3]} ";
                SqlCommand commandddddd4 = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[4] = commandddddd4.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Количество на складе {opisanie[4]} ";
                SqlCommand commandddddd5 = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[5] = commandddddd5.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Количество на складе {opisanie[5]} ";
            }
            this.Close();
            win_nout.Show();
            win_nout.kyp1.Click += Kyp97_Click;
            win_nout.kyp2.Click += Kyp98_Click;
            win_nout.kyp3.Click += Kyp99_Click;
            win_nout.kyp4.Click += Kyp100_Click;
            win_nout.kyp5.Click += Kyp101_Click;
            win_nout.kyp6.Click += Kyp102_Click;
        }

        private void Kyp97_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr1.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr1.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 1", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp98_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr2.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr2.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 2", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp99_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr3.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr3.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 3", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp100_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr4.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr4.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 4", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp101_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr5.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr5.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 5", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp102_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            string url;
            this.Close();
            using (SqlConnection connection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT [Model] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = command.ExecuteScalar().ToString();
                win_nout.pr6.Text = $"{opisanie[0]}, \n";

                SqlCommand commandd = new SqlCommand("SELECT [Volume_operativ] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = commandd.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Объем оперативной памяти {opisanie[0]}, \n";

                SqlCommand commandddd = new SqlCommand("SELECT [procesor] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = commandddd.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Процессор {opisanie[0]}, \n";

                SqlCommand commanddddd = new SqlCommand("SELECT [Pamat] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = commanddddd.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Объем памяти {opisanie[0]}, \n";

                SqlCommand commanddddddd = new SqlCommand("SELECT [Zena] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = commanddddddd.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Цена {opisanie[0]}, ";

                SqlCommand commandddddd = new SqlCommand("SELECT [Kolichectvo] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                opisanie[0] = commandddddd.ExecuteScalar().ToString();
                win_nout.pr6.Text += $"Количество на складе {opisanie[0]} ";

                SqlCommand commandddddddd = new SqlCommand("SELECT [Image] FROM [dbo].[Notebok] WHERE [id_notebok] = 6", connection);
                url = commandddddddd.ExecuteScalar().ToString();
            }
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($@"{url}", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
            kor.Show();
            kor.pokupka.Text = win_nout.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Admin_panel_Click(object sender, RoutedEventArgs e)
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
