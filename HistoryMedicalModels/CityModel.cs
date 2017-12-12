

namespace HistoryMedicalModels
{
    using System.ComponentModel.DataAnnotations;
    public class CityModel
    {   [Key]
        public int IdCity { get; set; }
        public string Name { get; set; }
        public int IdDepartment { get; set; }
        //llave externa
        public int prueba { get; set; }
    }
}
