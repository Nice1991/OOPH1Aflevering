using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal sealed class Course : Schooling
    {
        public List<string> SchoolingCourses { get; set; }
        public Course(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SetCourses();
        }
        public override void SetCourses()
        {
            base.SetCourses();
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("Programmering")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else if (SchoolingName == SchoolingCategory.Supporterlinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("Server")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("Netværk")).ToList();
                SchoolingCourses = schoolingCourses;
            }
        }
        public override void GetTeacher()
        {
            List<TECPerson> displayTeachers = new();
            Teachers = displayTeachers;
            foreach (var displayTeacher in Teachers)
            {
                if (SchoolingName == displayTeacher.Uddannelseslinje)
                {
                    displayTeachers.Add(displayTeacher);
                }
            }
        }
        public override string ToString()
        {
            return "\n** OOP H1 Afleveringsopgave **\n";
        }

    }
}