namespace Les_32_WPF_en_Databinding
{
    class OldPersoon
    {
        //Let op: Geen event noch interface!
        public string Naam { get; set; }

        public OldPersoon(string naam)
        {
            this.Naam = naam;
        }
    }
}
