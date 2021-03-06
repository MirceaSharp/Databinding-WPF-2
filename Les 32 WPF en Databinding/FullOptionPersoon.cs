using System;
using System.ComponentModel;

namespace Les_32_WPF_en_Databinding
{
    class FullOptionPersoon : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Interfaces ==> Loïc
        //Delegates en events ==> Filip

        public string _naam;

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

        public FullOptionPersoon(string naam)
        {
            this.Naam = naam;
        }

        public FullOptionPersoon()
        {

        }

        private void RaisePropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        //IDataErrorInfo:
        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "Naam")
                {
                    if (string.IsNullOrEmpty(Naam))
                        result = "Geef een naam in";

                }
                return result;
            }
        }
        public string Error
        {
            //IDataErrorInfo geeft validatie-info dat gebruikt kan worden in UI. 
            get { throw new NotImplementedException(); }
        }

    }
}
