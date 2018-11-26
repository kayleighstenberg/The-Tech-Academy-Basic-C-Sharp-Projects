using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Exercise
{

    public class Employee<T> 
    {
  
        public List<T> Things { get; set; }

        public string Items { get; set; }

        public int Numbers { get; set; }

   
    }

}
