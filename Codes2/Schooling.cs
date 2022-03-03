using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal abstract class Schooling
    {
        public SchoolingCategory SchoolingName { get; set; }
        public CourseCatogory CourseName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string>? Courses { get; set; }
        public Schooling(SchoolingCategory schoolingName)
        {
            //Liste over lærere og deres fag. 
            List<TECPerson> teacherName = new()
            {
                new TECPerson { FullName = "Niels Olesen", Uddannelseslinje = SchoolingCategory.Programmeringslinje },
                new TECPerson { FullName = "Bo Hansen", Uddannelseslinje = SchoolingCategory.Supporterlinje },
                new TECPerson { FullName = "Ole Nielsen", Uddannelseslinje = SchoolingCategory.Infrastrukturlinje }
            };
            Teachers = teacherName.ToList();
        }
        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
            {
                courses.Add(displayCourses);
            }
        }
        public abstract void GetTeacher();
    }
}

