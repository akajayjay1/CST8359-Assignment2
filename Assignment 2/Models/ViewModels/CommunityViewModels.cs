using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment_2.Models.ViewModels
{
    public class CommunityViewModels : Controller
    {
        public IEnumerable<Student> Students { get; set; }

        public IEnumerable<Community> Communities { get; set; }

        public IEnumerable<CommunityMembership> CommunityMemberships { get; set; }
    }

    public class StudentViewModel
    {
        public IList<Student> Students { get; set; }
        public Student isSelected { get; set; }
    }
}
