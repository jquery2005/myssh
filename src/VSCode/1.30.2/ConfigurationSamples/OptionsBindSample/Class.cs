using System;
using System.Collections.Generic;

namespace OptionsBindSample
{
    public class Class
    {
        public int ClassNo { get; set; }

        public string ClassDesc { get; set; }

        public List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }

        public string Age { get; set; }
    }
}
