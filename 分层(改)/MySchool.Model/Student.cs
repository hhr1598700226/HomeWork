﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Model
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentPwd { get; set; }
        public string Gender { get; set; }
        public string Grade { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BornDate { get; set; }
        public string IdCard { get; set; }
    }
}
