using System.Collections.ObjectModel;
using System.Windows;

namespace Les_32_WPF_en_Databinding
{
    /// <summary>
    /// Interaction logic for winBindingToCollection.xaml
    /// </summary>
    public partial class winBindingToCollection : Window
    {
        public winBindingToCollection()
        {
            InitializeComponent();
        }

        ObservableCollection<Persoon> lijstPersonen = new ObservableCollection<Persoon>();
        //List<Persoon> mijnLijstPersonen = new List<Persoon>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lijstPersonen.Add(new Persoon("Hans"));
            lijstPersonen.Add(new Persoon("Arda"));
            lijstPersonen.Add(new Persoon("Julie"));
            lijstPersonen.Add(new Persoon("Hugo"));
            cmbPersonen.ItemsSource = lijstPersonen;

            //mijnLijstPersonen.Add(new Persoon("Hans"));
            //mijnLijstPersonen.Add(new Persoon("Arda"));
            //mijnLijstPersonen.Add(new Persoon("Julie"));
            //mijnLijstPersonen.Add(new Persoon("Hugo"));
            //cmbPersonen.ItemsSource = mijnLijstPersonen;
        }

        private void btnVerander_Click(object sender, RoutedEventArgs e)
        {
            Persoon verander = new Persoon("Hans Van Soom");
            lijstPersonen.RemoveAt(0);
            lijstPersonen.Insert(0, verander);
            //mijnLijstPersonen.RemoveAt(0);
            //mijnLijstPersonen.Insert(0, verander);

            //Als er gewerkt wordt met List:
            //cmbPersonen.Items.Refresh();
        }
    }
}
