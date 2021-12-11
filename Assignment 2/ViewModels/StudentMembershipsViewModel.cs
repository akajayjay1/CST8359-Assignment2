﻿using Assignment_2.Models;
using System.Collections.Generic;

namespace Assignment_2.ViewModels
{
    public class CommunitiesViewModel
    {
        public IList<Community> Communities { get; set; }
        public Community Selected { get; set; }
    }

    public class StudentMembershipsViewModel
    {
        public Student Student { get; set; }
        public IList<Community> Communities { get; set; }
    }

    public class StudentsViewModel
    {
        public IList<Student> Students { get; set; }
        public Student isSelected { get; set; }
    }
}
