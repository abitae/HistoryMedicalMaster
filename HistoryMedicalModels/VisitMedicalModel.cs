namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class VisitMedicalModel
    {
        public int IdVisitMedical { get; set; }
        public string VisitMedicalDetail { get; set; }
        public string TipeVistiMedical { get; set; }
        //Llave Foranea
        public int IdDoctor { get; set; }
        public int IdClient { get; set; }
 }
}
