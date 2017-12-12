namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class InstitutionMedicalModel
    {
        [Key]
        public int IdinstitutionMedical { get; set; }
        public string NameInstitution { get; set; }//Color Orina
        public string TipeIntitution { get; set; }//Olor Orina
        public string InstitutionAddress { get; set; }
    }
}