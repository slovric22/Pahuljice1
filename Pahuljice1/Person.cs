﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pahuljice1
{
    public abstract class Person
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {

           return FirstName + " " + LastName;

        }
    }
}
