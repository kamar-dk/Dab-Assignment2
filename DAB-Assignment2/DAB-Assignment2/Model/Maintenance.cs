using System.ComponentModel.DataAnnotations;

namespace DAB_Assignment2.Model
{
    public class Maintenance
    {
        [Key]
        public long Id { get; set; }
        public string EmpName { get; set; }
        public DateTime MainDate { get; set; }
        public Facilitys Facilitys { get; set; }
    }
}
