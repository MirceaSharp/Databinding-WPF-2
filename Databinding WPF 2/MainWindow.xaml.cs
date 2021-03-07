using System.Windows;

namespace Les_32_WPF_en_Databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Persoon p = new Persoon("Joske");
        OldPersoon op = new OldPersoon("Joske");
        FullOptionPersoon fop = new FullOptionPersoon();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtNaamZonder.DataContext = op;
            txtNaam.DataContext = p;
            txtFullOptionPersoonNaamIDataError.DataContext = fop;
        }

        private void btnVeranderZonder_Click(object sender, RoutedEventArgs e)
        {
            //Zonder interface en delegate:
            op.Naam = "Jefke";
        }

        private void btnToonNaamZonder_Click(object sender, RoutedEventArgs e)
        {
            //Zonder interface en delegate:
            MessageBox.Show(op.Naam);
        }

        private void btnVerander_Click(object sender, RoutedEventArgs e)
        {
            //Met interface en delegate:
            p.Naam = "Jefke";
        }

        private void btnToonNaam_Click(object sender, RoutedEventArgs e)
        {
            //Met interface en delegate:
            p.Naam = "Jefke";
            MessageBox.Show(p.Naam);
        }

        private void btnBindToCont_Click(object sender, RoutedEventArgs e)
        {
            //Slechte naamgeving Window1 !
            Window1 mijnWindow = new Window1();
            mijnWindow.Owner = this;
            mijnWindow.Show();
        }

        private void btnBindToCol_Click(object sender, RoutedEventArgs e)
        {
            winBindingToCollection mijnWindow = new winBindingToCollection();
            mijnWindow.Owner = this;
            mijnWindow.Show();
        }
    }
}
