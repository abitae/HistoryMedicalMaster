using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryMedicalModels
{
    public class PersonalHistoryPathological
    {
        public int IdPersonalHistoryPathological { get; set; }
        public bool SurgicalIntervention { get; set; }
        public string SurgicalInterventionDetail { get; set; }
        public DateTime SurgicalInterventionDate { get; set; }
        public string complications { get; set; }
        //Llave Foranea
        public int IdClient { get; set; }
    }
}
