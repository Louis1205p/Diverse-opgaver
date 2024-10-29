using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutinerede_Opgaver
{
    public class ValutaOmregner
    {
        public static double valutaRate = 7.5;
        public static double ConvertToEuro(double amountDk)
        {
            return amountDk / valutaRate;
        }

    }
}
