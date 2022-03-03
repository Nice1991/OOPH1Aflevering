using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    internal class TECPerson : IComparable<TECPerson>
    {
        public SchoolingCategory Uddannelseslinje { get; set; }
        public string? FullName { get; set; }
        public int CompareTo(TECPerson? next)
        {
            return FullName.CompareTo(next.FullName);
        }
    }
}
