using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HR
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string IdentificationNo { get; set; }
        public string Department {  get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartingDate { get; set;}

        string connectionString = "";
    }


}
