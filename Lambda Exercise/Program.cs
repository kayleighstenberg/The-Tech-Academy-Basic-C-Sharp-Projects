using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lambda_Exercise
{

    class EmployeeList
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<EmployeeList> employee = new List<EmployeeList>()
            {
            new EmployeeList {Name = "Joe Smith", Id = 9},
            new EmployeeList {Name = "Michael Scott", Id = 5},
            new EmployeeList {Name = "Jim Halpert", Id = 1},
            new EmployeeList {Name = "Pam Beesly", Id = 4},
            new EmployeeList {Name = "Dwight Schrute", Id = 11},
            new EmployeeList {Name = "Ryan Howard", Id = 3},
            new EmployeeList {Name = "Angela Martin", Id = 7},
            new EmployeeList {Name = "Kelly Kapur", Id = 8},
            new EmployeeList {Name = "Robert California", Id = 2},
            new EmployeeList {Name = "Joe,Jonas", Id = 12},
            };

            List<string> joeList = new List<string>();

           // var newEmployeeList = employee.Select(x => new { Age = x.Id, FirstLetter = x.Name[0] });
            foreach (var item in employee)
            {
 
                if (item.Name.Contains("Joe"))
                {
                    joeList.Add(item.Name);
                }
            }

            var joeList2 = employee.FindAll(x => x.Name.Contains("Joe"));

            var idList = employee.FindAll(x => x.Id > 5);

            Console.ReadLine();
        }
    }
}
