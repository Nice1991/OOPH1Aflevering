using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes2
{
    // Vores Enums. Description kan bruges til at skifte navnet på ens enum ud med det der står i Description. 
    enum CourseCatogory
    {
        [Description("Grundlæggende Programmering")]
        Grundlæggende_Programmering,
        [Description("Objektorienteret Programmering")]
        Objektorienteret_Programmering,
        [Description("Web Server")]
        Web_Server,
        [Description("Database Server")]
        Database_Server,
        [Description("WAN Netværk")]
        WAN_Netværk,
        [Description("LAN Netværk")]
        LAN_Netværk
    }
    enum SchoolingCategory
    {
        Programmeringslinje,
        Supporterlinje,
        Infrastrukturlinje
    }
}
