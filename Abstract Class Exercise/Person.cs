﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Exercise
{
    public abstract class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public abstract void SayName();

    }
}
