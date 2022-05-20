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
using уп;

namespace уп
{
    /// <summary>
    /// Логика взаимодействия для glavnaya.xaml
    /// </summary>
    public partial class kat_kovriki : Window
    {
        public string zagolovok = "";
        public Image[] image;
        public string[] opisanie;
        public kat_kovriki()
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
        }

    }
}
