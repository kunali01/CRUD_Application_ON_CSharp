﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application_ON_Student
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"{Id} , {Name} , {Marks}";
        }
    }
}
