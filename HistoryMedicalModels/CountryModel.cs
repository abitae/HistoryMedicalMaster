namespace HistoryMedicalModels
{
    using System.ComponentModel.DataAnnotations;
    public class CountryModel
    {   [Key]
        public int IdCountry { get; set; }
        public string Name { get; set; }
    }
}
