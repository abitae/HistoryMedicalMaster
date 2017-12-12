namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PersonalHistoryPathologicalModel
    {
        public int IdPersonalHistoryPathological { get; set; }
        public string SurgicalInterventionDetail { get; set; }
        public DateTime SurgicalInterventionDate { get; set; }
        public string Complications { get; set; }
        //Llave Foranea
        public int IdHistoryMedical { get; set; }
    }
}
