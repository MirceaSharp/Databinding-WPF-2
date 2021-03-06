using System.ComponentModel;

namespace Les_32_WPF_en_Databinding
{
    class Persoon : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Interfaces ==> Loïc
        //Delegates en events ==> Filip

        private string _naam;

        public string Naam
        {
            get
            {
                return _naam;
            }
            set
            {
                _naam = value;
                RaisePropertyChanged("Naam");
            }
        }

        public Persoon(string naam)
        {
            this.Naam = naam;
        }

        private void RaisePropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

}
