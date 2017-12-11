
namespace HistoryMedicalModels
{
    using System.ComponentModel.DataAnnotations;

    public class DepartmentModel
    {
        [Key]
        public int IdDepartment { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }
    }
}
