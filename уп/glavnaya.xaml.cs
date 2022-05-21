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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-74.userapi.com/s/v1/if2/3Ikf2tjE5mxY2bV8ttkWcsWUiIBBiVp_tW83eZLuG4tn_A62J06pET_KMwuYWbCeUurFzpWRpLCjyc6BBUHGpVss.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
                win_proc.pr6.Text += $"Количество на складе {opisanie[0]} ";
            }
            kor.Show();
            kor.pokupka.Text = win_proc.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp5_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-34.userapi.com/s/v1/if2/0TYM-PEZGh72r2M8oroqOFY0KVUPKZwYzVNdVEeh-ioIVMumx9CUYAtIVpHa96YmHo856qMJZkr5yGPACyFF4jYs.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_proc.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp4_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-17.userapi.com/s/v1/if2/oCg-0CjROmu95WqLpXyMuOV8TY5JQPoS4TNCSRpRGgc-ZpJ87SAaXO_5muU8XSZ71bEhOGDG49u8CVIamqjTvcQe.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_proc.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp3_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-65.userapi.com/s/v1/if2/FvEgKmvETB13D67sasyK-4gs3_JX2BurJRZf8E_HgVTn_mqBp3v1xFqZC0h7dgceU6406OgQeDYr7pHit7kItPuS.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_proc.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp2_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-83.userapi.com/s/v1/if2/ktFELEbfhwhEREc2SZ3afsrH5-J5fdIbEQvkZPiIdK3Faw4TfdE2lCE4UYzVhhunFFwh9iGY6N8szEqejUkMNHsd.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_proc.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp1_Click(object sender, RoutedEventArgs e)
        {
            katalog win_proc = new katalog();
            string[] opisanie = new string[6];

            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-80.userapi.com/s/v1/if2/sna4Yhq4-nMWkbX8PP8IQbKKCDGFhxqGyvVtDrvzxbZyQfUG1uTTD99YnkTzJxZAqN1Qvq799RN-YcQiwWhQMktI.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-15.userapi.com/s/v1/if2/fDNvcx3UF1g5IBQwDZQUr0HRbVpWtbXNfnvY9BBR1YFCQkI7y9nEAFfa7WX-vd9R40s2qu0qDdeECsVBU551RQme.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_mat.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp8_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-87.userapi.com/s/v1/if2/rsxPi6cd-a9YYoYDMjt_xEusKyIYx1bFE9Zld2gF3q0jeEnjv0NThDcXGSPAr2dX3bKuV3TDa2AdT34_7amHzHik.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_mat.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp9_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-68.userapi.com/s/v1/if2/nm4-4Yn12MoUjNTFWBKj9pNTsbVh4uVrKpLRWyeFbrtixnJ6A2RXdPx-CN3jWQnvZuiO4YGBcLiPcFe6_r7I9_AI.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_mat.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp10_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-33.userapi.com/s/v1/if2/jnnamoYkmds9lhlMdnpv_IV0AatX_fyekn6lVmLvKk9_nMm3sQJocmyo2CKGgyYnH5DB8uMZdHiiRnjxHz8SnPk9.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_mat.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp11_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-81.userapi.com/s/v1/if2/VUrr8yGLTb322ei65tORsw0zxgrG71tXJ6p7_JtFPyt3sX5IIjsVxwIuKfUE3CZ0vHyE3eGpzuvPV2PX9rwACcrr.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_mat.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp12_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mat = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-20.userapi.com/s/v1/if2/uUW2ikgtZ6yOtXF6bKbsTzv5mRYZINK2Ssgz73Bs1TlLe4Ij2-aT1WrjFPnPUcJG6Z26QxeowYhgBBsOsKYqNqYI.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-60.userapi.com/s/v1/if2/QzM_40yzR7zo4qAPQ8rW1oIi_HuuW6VUOm909ejhJi8Ch6dS6i3yqErO29TyV7mgSL3RcNZFMfXPTZTiRxyvhrfh.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_videokart.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp14_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-22.userapi.com/s/v1/if2/XTXnW68A_o1qjbZmEGAPtPj98C6zYCYWJkXogFTQ-mRVyv01kYZw-0lb0WDN8oyTIRmuZonDFppUBG-TJWSuLyD3.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_videokart.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp15_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-7.userapi.com/s/v1/if2/pnPsyq_HPq21K-d4-o45yyi4mhtt0cE42BdvD5_bvBFp7hzZcMa4NRoGMZ-btgN89uwlZ_HPh_ld60pPJgyrIvoL.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_videokart.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp16_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-86.userapi.com/s/v1/if2/w-kgXQ5Hjlgiad72LjLAdSvEPz66UVjik3jVGqUA8L3Q1uDYhH2xbVyY3IQ2wzDpyKJrCUuIohy04jcvP3eZz1_4.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_videokart.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp17_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-42.userapi.com/s/v1/if2/KmKkatBwnHI83A9rDHiav2f8SVfH8nxOy2f8IIqspJrtobz4U74kPsbDeaHbxPLei58_WA-VTp_GYhtue9co41AY.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_videokart.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp18_Click(object sender, RoutedEventArgs e)
        {
            katalog win_videokart = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-22.userapi.com/s/v1/if2/fHNLf6K54J0SeEcpRj9xtxNAtE4X5z8wayvxqLUIcvd2GUYzgnHWZYWZ5ri5F3U5R6DYPWQrrnWLvQ-8_wya4ky0.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-7.userapi.com/s/v1/if2/c9CaRdAyJ5G5Ne3W2UsGPQEn9eZw_nxlTYwKA1-8FOH4rlredolBRLJm0-5NL-Vv5HQqJ6he8oK_lngI3cuuYJYJ.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_opera.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp20_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-14.userapi.com/s/v1/if2/CiGG-4WVgLPgHBt3bf5vH7J46hcS_X2th-sf2bCCxKBWBV_3RHla2xJcIzQKcXNgNGWelRfJSie0BIJmmqRBTxaK.jpg?size=320x87&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_opera.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp21_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-38.userapi.com/s/v1/if2/FczrBoz5pjkdkxi0ij5Xwwgjr0IgZUE3_hY-Sz2V4VrRCV7T_JdK9PL5KoS2LhBL5r9dDih8iditR7Nc-yfQLOXX.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_opera.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp22_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-29.userapi.com/s/v1/if2/wQggFVH1XaWI1VqkrEFGRIMu7fs11eZgKa_9dhJfdfe7EzNJPoyMSWT5Ocw2PbywyCLvDUdKNGxyYC9B86ZshOax.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_opera.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp23_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-45.userapi.com/s/v1/if2/pod4L3FQNG48n2slZqj61Isi9_WrupV8SecsE-u09eoWvaWpH3ZJgQ7dlvsO906U0pv-r8jEwSciEEjg6pTlxZOW.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_opera.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp24_Click(object sender, RoutedEventArgs e)
        {
            katalog win_opera = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-49.userapi.com/s/v1/if2/xMkEOX9XDtCjh-EcMJHdS27B_U_9dlLCwNwM1JhxJwJ2tjTJD_w2aGbmiMNDXVO8nd9IQ1amWEugjHupGeTLc13U.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-12.userapi.com/s/v1/if2/dcYPjMtGADxWN0KO7wTmaxtp9LekbLeMAWKlO0b1CFHpwzLQf6N7sk5BoNsnudpCeL8Jtfjt2T-NICs8sQ6XvLTz.jpg?size=280x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_bloki.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp26_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-69.userapi.com/s/v1/if2/tmclKh1FAHCBn85DusRICwm7RbA3da5R8yulNCxBmcGyPCUz79SpNtKrO_x5ZFKIGAgY4Xm5Lo3xAARz155zdpYp.jpg?size=298x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_bloki.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp27_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-77.userapi.com/s/v1/if2/R_Q-sBQhkev7C1F06AH835nSlHudS-F90-wNUhG5VIzKeLaqH49PKdLWzbQCgNWdynmO5HpWd9EYhWoni3tFsruo.jpg?size=2000x2000&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_bloki.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp28_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-18.userapi.com/s/v1/if2/DSHrl9jfH69Fz4cfKdf7Z8XS_653Rhiu_nKHsEb-KniDqjpxdok4t_WUHSBj4G3XBdhUaMMMvl1xx37ciKhHJkhx.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_bloki.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp29_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-14.userapi.com/s/v1/if2/bNz5ku5DktKLetgTNAuT3NF5YcXkKdi02rw_YuAkSYD0zB5VX96UlbnnceKk54d8rPOx0w56LezGLSh7Hh6kw7Wk.jpg?size=2000x2000&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_bloki.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp30_Click(object sender, RoutedEventArgs e)
        {
            katalog win_bloki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-61.userapi.com/s/v1/if2/x0pOf-h18vR3hY0W_25HTez8rekLvjWXu5fjUJTZgc55JXSfJlN2sxIqEX0MfguQzBQUwaZmwVPakG9v5x2T9jGV.jpg?size=293x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-50.userapi.com/s/v1/if2/zvpBspSe3oQf98Ch-wdxtGXaJzVx0etyqFSXXYJt8deH0hQx9BjSpbi2WAgko3U-M6yZaiiMqP_HGXaSIaJYJrVN.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_korp.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp32_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-23.userapi.com/s/v1/if2/Dq3vj1JOWcbkgJMOh1M9TT1ESTPNId2WNcmziKWg0TYCB2SoaZaaer3c6hwYgaZmGfs6JjKaymcMn1O2_ulofXWy.jpg?size=212x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_korp.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp33_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-62.userapi.com/s/v1/if2/WgFEyfIF2kGQay4wTv2lviEgLeVcHMsQibOrcIo28m2N_LUUq2r4zz01Sh1JWkT2B0A8BdOymMIP-Yo2JCwuAHG4.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_korp.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp34_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-57.userapi.com/s/v1/if2/jJTQdQLq_z9SkqSNShCxI_pxCL7YS_ZedN2iiPWz8Vhu1xn02c6siOUdLB23IwbN3kDsSp8jcBl-irKJuIncmQpQ.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_korp.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp35_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-14.userapi.com/s/v1/if2/hRxqO3132f4KuJUxIDCF5NsfI7tXmhkl9dxQU-_bOyFg3pl3pAiJz3_GjYWWw4uM9tztrGzG_Aw8UyySD4vsFQzA.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_korp.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp36_Click(object sender, RoutedEventArgs e)
        {
            katalog win_korp = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-13.userapi.com/s/v1/if2/N3fFSOfXDKzUC-vx8tQx5zzQwMOkHXR7oS5Xa8jA3DlEAkt0Vwyd98ltMD_8S8I1Xxka7LYH6bPl4k0Qotg15GLf.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-28.userapi.com/s/v1/if2/IhHfCR-OUXQickpAkTpc7cAFcHipA_103XCd9U6N4D6-P_2SGUbjZw-HyScZup1i2yesj42eN_n4pZwGpEF-QcVP.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_oxl.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp38_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-77.userapi.com/s/v1/if2/OygmTg3QcTzUCzfBIKVUYEeE7lCNbMYLqgVorvmhdrYBEvhL--vNQkfNAQ1TEHF6X7IeNGKF-paqbjj_3jtoBU8k.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_oxl.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp39_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-30.userapi.com/s/v1/if2/W4h1thqBYkTrEVg0HlIFg03cMPW5d_5r4r1uuNKwztXXEvm-DUDpO_px6-27vY0m62LcL-xjaqluYnLO0SD6QnjG.jpg?size=451x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_oxl.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp40_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-24.userapi.com/s/v1/if2/B3S4rlCA59noC2Ts1UlUogGBXZ1tlU74X7lfiVMF17shbHKdZATHsdItINr41oITNe-9qB-6ozQp2T3m1supY7HV.jpg?size=369x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_oxl.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp41_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-73.userapi.com/s/v1/if2/KcpmXdvFK4_vMaGJJhCwJIgkQa4Y3xoYIbLEhU3IiKGa25dSzbhX1PklQ1rNupgGLjRq9HmEUUzef9HqxaYl_4c-.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_oxl.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp42_Click(object sender, RoutedEventArgs e)
        {
            katalog win_oxl = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-33.userapi.com/s/v1/if2/dY5T2kyWN5Jd4sa2QKW6PYc8oH2kmjBdxFT8DOW-vdRW9NeqAGGaJmWxVjR55sHOLMBXm5bi2OuMmzTOyn8WxJro.jpg?size=320x240&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-58.userapi.com/s/v1/if2/dZFnrd2GB21VHL-7n44G72PmsX6BOgu0zUj9-vEFwGPHpdDkrHYun3IzrAnA46tAi4Drug82-JEx_81xMF9fiIVv.jpg?size=188x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_ssd.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp44_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-80.userapi.com/s/v1/if2/MrBbvzEVQ0NwTyECcxThzwVXvLPZWfwCGfaCsKLU9b32Bpk2lWD_KBg_U8AbNripGCbO4fQzH2JDOYf6FEHL4aMT.jpg?size=174x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_ssd.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp45_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-86.userapi.com/s/v1/if2/CuJ5SfMEr7eturV1hLvmaaoqTkJ_lWx7mlNeAx6PNy13lO3J7E7tj7cKIDfHkV7Jovt4FAizjwsITsGrfzSGiuB_.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_ssd.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp46_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-21.userapi.com/s/v1/if2/gwcR8LaAyEmebOUatJ8uU6WHN1Asvx6gs0SuQJd5ewtDW28l9EctDEfjo2vypiRZQo5wCqRHzCwrcpUsTHaCCYev.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_ssd.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp47_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-38.userapi.com/s/v1/if2/M8-V5_a-a1xg_ASHIRbp6GOtw7GKhcttcPMN9uiXYWX3dx2KzSzA2egsCcjiRNeGZ6CfCyrrpDmzUXIn2xAXwCYU.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
            kor.Show();
            kor.pokupka.Text = win_ssd.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp48_Click(object sender, RoutedEventArgs e)
        {
            katalog win_ssd = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-81.userapi.com/s/v1/if2/I4ERhaBE-U0YErKYzxM2z2vN_If3xXGZKT6YbzeQOFJlgOT879hxY9hywO5QMTpAUsnv3DFBeOeBLlGiZi5d_BdY.jpg?size=175x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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
            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-54.userapi.com/s/v1/if2/-bRBabmQT9BGG6EO8LREQAWMwvEuD9JoezvkVr2hzgt06bYCeIHEXWz5pSX-sPrHq3P5UpDEL0O27Z1LVFpjPJ-I.jpg?size=500x394&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_monitor.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp50_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-75.userapi.com/s/v1/if2/0cYrhIwPKkrbZjnwSJ3SK45PfxtCAYcWB7hEP7fJSWA2w7J2tJdHvImdpQQCax3jDbQfG73xklG6drDnexBxjy_a.jpg?size=500x383&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_monitor.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp51_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-31.userapi.com/s/v1/if2/hl4rky3TDPEeto_fESC7JvnAwaqtMpIQgKFX7Fsx-mAHrZ9uijrO7lFPlg6VSxlDxOHyJKTJsV6p6KUWyIbFkIno.jpg?size=500x390&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_monitor.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp52_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-76.userapi.com/s/v1/if2/kKhC4ZDaiVpha3WN616Bwagvi35vDDrPZIwv1agmgsjga42paa14GIjbxZuFH6jsTnvY99xJwC39m6h-n5hL3_Y6.jpg?size=500x427&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_monitor.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp53_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-71.userapi.com/s/v1/if2/gFMe05IJtaf89_Jc_9Hyk1yE8vwFRe4djc1CUpo--iL1NY204LwNAV3bRkWswbWSr3pWGAtYX14VOpJl2xWRGNdq.jpg?size=279x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_monitor.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp54_Click(object sender, RoutedEventArgs e)
        {
            katalog win_monitor = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-33.userapi.com/s/v1/if2/J6rtLRGlSDwIysZH8uiZjfTVP1MtjQ4laMJDwDYXohDgOzIjFjU0R4JETPgM8iJZklh6tZZAa2rZ0KqtxZohRzbB.jpg?size=500x387&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-15.userapi.com/s/v1/if2/hJluBPMcqOq88pgGGCMNQhuoO_Rai-i8PtGIJzohSlIi_e1eGwYtnuYKAriiqqgVkS67iGIc-cMWBDrNbzZWWsK1.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_klav.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp56_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-5.userapi.com/s/v1/if2/hL5EkKfc49FOJFkh6eB98kHPoUpxZ51tSsNFmcb1z_wshua3uSOo6UU7RV2Va0o2C5DCXwmURTWMSax1_1819HvG.jpg?size=1920x646&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_klav.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp57_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-65.userapi.com/s/v1/if2/rLjI83Xg8XxgqarX36jQwUZ5dpvYdtKCfzg6RDvt5FjsOwk-B4fwT840wTPBfQfKzSD92HdEXn5e63yOsLQ08wLc.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_klav.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp58_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-12.userapi.com/s/v1/if2/WxNQqckFv_yfcN6quzDb17jh_gIonON1HYUdJ1QDdF7sEdTtNW2RasDCsUUuu-xeUX9NypDSYF7k42VXc_wYX_Lh.jpg?size=500x191&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_klav.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp59_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-54.userapi.com/s/v1/if2/SCqkokFC4xrLx-uplEnb8BDqbjN-Mqowd__SSy0gbvVjucSFGMjNzflb8LUnAla4gY29C16lVAVcuflXGvfj71AV.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_klav.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp60_Click(object sender, RoutedEventArgs e)
        {
            katalog win_klav = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-60.userapi.com/s/v1/if2/9k76FXHcFTwIcUTyyvqoeRWtYRbgvf3ikIdrKC8EvBZDH9TeTvz50GJCeMrvzudPXXtk6TOS9O-VCzjDbIS_2o4m.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-27.userapi.com/s/v1/if2/go7NJ6qWLS_qvWpNCjfmU5fLNqzk-2bPmEnQwHaxwE005AQ4CZ-04oyGDoxphqokrevebDTzLToujH_kkuTreIto.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_mish.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp62_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-40.userapi.com/s/v1/if2/YgFmhzCFOMvbBn0R8qzfg6m1MQG1vsTbjfiKGEAEA3NL02MF-w7tX23-2z7RuQLeG3vUdqQt52DX_Wm1ADpfGh6m.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_mish.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp63_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-53.userapi.com/s/v1/if2/t1DJcCcMXau5VAgtRJlDvxhHD6B46xt0g3KWZ1qdkPiwYlTdBHG6bC9ITNAesC8YfxJwy0j_uTevKyDE1EN52NBq.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_mish.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp64_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-31.userapi.com/s/v1/if2/wHi7A691E0Zdn-a0h3Pqb7KjOf6K7BbyndJVF3JxvslaagDw3ixlwhsWDwC06Hm8FCL8AS41-f6R8NzmJE_zZBIb.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_mish.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp65_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-23.userapi.com/s/v1/if2/yZMcKfnv-AzVYc8SRI1qociiPIsygMIPWJXAp3eiVEVX4IrW8Asa95AoaIAYfQ2i6wuPmrCl46DEaneMHQ5qBdfQ.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_mish.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp66_Click(object sender, RoutedEventArgs e)
        {
            katalog win_mish = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-28.userapi.com/s/v1/if2/8KfGSFrrWVRnT4J71oaCN1GREeHEefER54zRYxHvr7CYi48tlMQsYyfpVwCqLdjXQZuLKT_RjKQP50sWhjdWJI9Q.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-58.userapi.com/s/v1/if2/YkQeYhFIyA5we1oXMBwuiIr4FqHV29loj9_urWRns4G-2L1NN-N-j9ZcpXI_eATrC0zKtf7FKTgnNiFBNKDSq4bk.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_veb.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp68_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-81.userapi.com/s/v1/if2/n-zjCoQB9q0ySRsoooTZrk6i9oVULrQnRfnLuwyJ4UUvYOQeKggs4NcQKFZ5RmRW3fDuzsBlJFNXkGaStP-DiGp1.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_veb.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp69_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-6.userapi.com/s/v1/if2/rualYTVJuYxBy5FnL7zueVjAmUD_XK7-WX0EuDEh_aa4TEo6UZaW-pEYbmUNcdtHRBsRGWjiiZ6bEWtSd0b6kV8O.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_veb.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp70_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-19.userapi.com/s/v1/if2/_qO_83emTn4joJR3ApJRpdGbVidW1WhzSNioxFFbbuM0g137HpHtmB2vveS90sT2__yl5wIidUSbvptV2x7ORwOl.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_veb.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp71_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-83.userapi.com/s/v1/if2/ycdvwdW4NAVKjJHUzxrnRa0cNZ4kWUaBfiU8WvIC5gOhCgAAyleJW-kUvsRaEMiGwdT0e2M2TuMuk6wGD2eNd_R8.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_veb.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp72_Click(object sender, RoutedEventArgs e)
        {
            katalog win_veb = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-88.userapi.com/s/v1/if2/1kpHNNbcgaUiSPZtQO5eK6hziR3YKW6AcEcRIXl06UZw1L5diAMO0Amdcfe6oQiKm3aTeXIOWfi4Zyt4EQhPiFqS.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-24.userapi.com/s/v1/if2/4FGMxymh9yaiqb-eCgeISsks2-yj-Kar1M0Xd8jtVry9yGSgDOSqXwiofMP5o61fk-TEl66PSEzedlBVPTKe2qM-.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_dannie.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp74_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-63.userapi.com/s/v1/if2/G4QEsyCk6oEN_lB5C7greQDGVdjq15zeNDWax0W775EAuhEWY4_jetBYQVZM9qkgdSoA49S_Hnl2ynHf1Fp9hdpT.jpg?size=174x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_dannie.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp75_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-77.userapi.com/s/v1/if2/5ukpJQ2O_pYnouRRvxO2iFHdseIFRJLOluunZTkFizOnS2i20Vz_VzbWg8T_61d9tUm6iVTF4Fc12-VeZaG2W2am.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_dannie.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp76_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-56.userapi.com/s/v1/if2/Be9xPJm5PLL3ckTOlNcjinoGBp3nlEMyZzwe1yde8Hm4cpmV-JMqjghJMoBq71u_omjVh1A7wgH7ETAI7fT1fBw6.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_dannie.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp77_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-80.userapi.com/s/v1/if2/nvM3M0MAAXO43qnGXDgVV7yPlv5d1S7WG7im-BkCvZKDz7tyk7Ui8OU-t5dh1xNuhtUGUUVZ2n0Bnxxyn-u9nEig.jpg?size=249x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_dannie.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp78_Click(object sender, RoutedEventArgs e)
        {
            katalog win_dannie = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-20.userapi.com/s/v1/if2/JN9qGdENQ-zKYiIIuF3Wnf9BJHsXxk-B_Bq-_Goylxoqd8d6XtqUnexHSeJCTJecWAdVoo9ENmOibVJ_zHAWRc5v.jpg?size=221x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-79.userapi.com/s/v1/if2/Z_GzpkbT1cUMw0V4rpgc_UE4_aWyCHzsiQMT4NovIQMwk_FMxDQLetQggJP6PVmzawnTAS9feBxn-z5nknlF32Vf.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_naysh.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp80_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-11.userapi.com/s/v1/if2/g4VrzqE9D6RaMx883kqxacr10vcrcJALONxpl66sMXH_NjfLbwdUZ_aG-kU7Em8MB0MwRz1rsU-cMeCPuYzCa_Gs.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_naysh.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp81_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-44.userapi.com/s/v1/if2/rYplvlYeKlDN1FCdCvA9c7guAN1o00ciLsJHkFEXjzAudtD_sIabfHyHPMADMNJciIq3kDa8fMC66EGj81YzX4cE.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_naysh.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp82_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-2.userapi.com/s/v1/if2/t90V9tGfeYueBd7QUwAZHyQlSRXCDO4OcV3H7djP9DftnGozugBQ50va57v2DX_gMSp0nG5m8oF2_z7aMtNIseeM.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_naysh.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp83_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-21.userapi.com/s/v1/if2/GAxUmIkVMZzTstKxAPIB5GH4PmXCDfdscO4-IusXmPxLSP4bMx4n7ZT7wHvZgP3t8UX12UiZgCcgQB5Ufhr1RGeB.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_naysh.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp84_Click(object sender, RoutedEventArgs e)
        {
            katalog win_naysh = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-41.userapi.com/s/v1/if2/z31XrGP6XQj7Ar2iNGvK3qeDYyVvQ8i3S9cKmWtUd3Ug9E36YXTB3KAUnuXeZ-_QB-0SuFaU1HesxnHbKbwgacak.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-45.userapi.com/s/v1/if2/6ihqLedokA4C4LZ2tWYrpF91G1wJ_02Dtd63cCU3U-vgcxlB7IPVIyUI4ENSVlQJoddGc2Twy5O0gn4JpcMvag2J.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp86_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-82.userapi.com/s/v1/if2/FGixl3BIusER6PWetWMY69uXqMbvm7g4YDbIJW2o_haXtUURcBCskMJabIJZ6zaMgNfkmNf05QNsq49YaQLyBmRd.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp87_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-71.userapi.com/s/v1/if2/hEk6FZrwYF5nhYmWBGr-mbq3i1IDo500vyBr0rHSqj4kAmGfJXJVD-NV1XRkSUK6GcvJieaodGS5YlxvzmW2q-UW.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp88_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-48.userapi.com/s/v1/if2/7h06Y55g0Np_jTzE7qLE5-tX26ezkzHju99UbYtjCsnKYv5HS6_e2_0nG6U6aCiu0Q2VTz5nbnsyMQhOGjWz6qoe.jpg?size=500x453&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp89_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-22.userapi.com/s/v1/if2/KMXGygT36VFTJ6xs2ehhj2Of1eT1qBRBNBpoz14HNVuaHnQzSNl5tA5e_4v0mf2QJY0waFL_vi7NGE4RBV9v4VR7.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kabeli.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp90_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kabeli = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-50.userapi.com/s/v1/if2/3FGe_xchFMuaWVHGPrw8qmsZCL2rVSx7a5X2Lg_RODNg0XJoOb4uptXMM5swd2fLXdyVdwZLkkLLnIAk8_v2VmJq.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-33.userapi.com/s/v1/if2/tCBAl939NUy-H1zG9iTv-6s6jm1FulouvSA1lvlYPU0gSyPWCwBnjqVhNnXex8FgSkW0yKIp9dE2jb78vMGeAWui.jpg?size=250x250&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp92_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-59.userapi.com/s/v1/if2/fEkogG8N6ea0IB7ekj3MNQRE-ZEjRwoQBChpKUtbOOBiz1CTNB1Jjfn64nyLlXydDQZG8Yt9KATstUNfCoTpLkGb.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp93_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-20.userapi.com/s/v1/if2/TTi6H1b4kDPc_R1h-wHdszjXyGpeceFSvP9qG3x2z1iToQn8A2uvwKwdFKRPXekDBKTaqyISApA2UWv6dOn8zKZ_.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp94_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-12.userapi.com/s/v1/if2/YuFIAQSf08TBX16J-g2fU2foWMHYlQ13ozSNEnosiL7ayIiC19ONdmZOdCSe-gaBjZ3fetIacw912WhVHMrNkY1I.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp95_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-82.userapi.com/s/v1/if2/Krlw_w9OHRBL7wEhGVlmpVoM31sVVR4_qQARmSYSiz6uliv6WJgKjS4QGKzTw1OaRp9BgkTWwMn8ErtrKccF6ifX.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_kovriki.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp96_Click(object sender, RoutedEventArgs e)
        {
            katalog win_kovriki = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-51.userapi.com/s/v1/if2/3izsdUxdCK9cWHWFXiRaDwisJLsSiI5xyDqCNsTB422No7he0nUCmkZbkht4Km-QHilbzu4tCkMVyUUg6cJqc1bd.jpg?size=500x500&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
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
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-65.userapi.com/s/v1/if2/lYsDWo8jt47w2OMOHxjuRwU3K7-S8DVpWKL1BgnYfh5zZtrhnUA75Jdhc7RPxqs9ynpj2hZRT5k2tOkh0Bb7ri9H.jpg?size=500x395&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr1.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp98_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-76.userapi.com/s/v1/if2/139e4AtaYGc8SLZuOD-aesz6P2HOBPv7yJ5clEDR-Cyx9OLi9F12uDJpaCGDQMGw5jRICDuO6NRQcvSM2Kml_CL8.jpg?size=500x335&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr2.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp99_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-29.userapi.com/s/v1/if2/t5Wj3W9rebcSyM-9ivtTcmg6QhPKB7pSVWhZZGr1xHWknPGw7_REaG6d7G-u3TW_VCF1sz8uV4KqSyYO-qg2RA9i.jpg?size=500x339&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr3.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp100_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-23.userapi.com/s/v1/if2/_FdVIkdbPixk4uJtLENMyH8zup19VZgTS7UZQ2UKRfvWk8b1ocqbXNSloJOQTqxv4o0-ZFlgn5g0sRreC5CLVECI.jpg?size=504x362&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr4.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp101_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-60.userapi.com/s/v1/if2/TDWR95AmME2GifgwC4J7qWQONj-1IdF8ipOiEt7-V5jp7QgeajuOSoqoCe2qQMrtINioc2gE6hBKH5Wo-tR4OMTm.jpg?size=320x240&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr5.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Kyp102_Click(object sender, RoutedEventArgs e)
        {
            katalog win_nout = new katalog();
            string[] opisanie = new string[6];
            korzina kor = new korzina();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"https://sun9-49.userapi.com/s/v1/if2/F6BwJ4slyGTGiB9Zsa86fXCmQ3vNXq_-rbX1QQUlKO-8uwYjhtAHsDtP5y4HYytueUCt4YgRwcpp1nSQUql0OuMJ.jpg?size=320x240&quality=96&type=album", UriKind.Absolute);
            image.EndInit();
            kor.im.Source = image;
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

            }
            kor.Show();
            kor.pokupka.Text = win_nout.pr6.Text;
            kor.oform.Click += Oform_Click;
        }

        private void Admin_panel_Click(object sender, RoutedEventArgs e)
        {

        }
        public SqlCommand Select() // функция подключения к базе данных и обработка запросов
        {
            SqlCommand dataTable = new SqlCommand("dataBase"); // создаём таблицу в приложении
                                                             // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Man_Sor_V_A;User=33П;PWD=12357");
            sqlConnection.Open(); // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand(); // создаём команду
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlConnection.Close(); // возращаем таблицу с результатом
            return sqlCommand;
        }
    }
}
