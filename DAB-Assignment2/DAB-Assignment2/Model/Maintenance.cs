using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
