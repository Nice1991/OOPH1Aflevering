//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes1
{
    internal class Audi : Bil
    {
        public string Model { get; set; }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPH1Aflevering.Codes1
//{
//    // 2 problemer er at den ikke kan arver fra 2 klasser, og den klasse den arver fra også arver.
//    internal class Audi : Bil
//    {
//        public string? Model { get; set; }
//        public Audi(string? model, string? mærke) : base(mærke)
//        {
//            Model = model;
//        }
//    }
//}