﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page79
{
    public class Employee<T> : Person
    {
        public List<T> Things {get; set; }
    }
}
