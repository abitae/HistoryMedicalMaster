namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class FamilyBackgroundModel
    {
        public int IdFamilyBackground { get; set; }
        public string Relationship { get; set; }
        public string Lives { get; set; }
        public int Age { get; set; }
        public bool Life { get; set; }
        public bool DBT { get; set; }//Tuberculosis
        public bool HTA { get; set; }//Hipertencion
        public bool TBC { get; set; }//Tuberculosis
        public bool VIH { get; set; }//Sido
        public bool Cancer { get; set; }//Cancer

        //Llave Foranea
        public int IdHistoryMedical { get; set; }

    }
}
