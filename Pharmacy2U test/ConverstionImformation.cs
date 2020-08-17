using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2U_test
{
    class ConverstionImformation
    {
        private List<String[]> ConversionInfo;
        string[] USD = { "USD", "1.31" };
        string[] AUD = { "AUD", "1.83" };
        string[] EUR = { "EUR", "1.11" };

        public ConverstionImformation()
        {
            ConversionInfo = new List<string[]>();
            ConversionInfo.Add(USD);
            ConversionInfo.Add(AUD);
            ConversionInfo.Add(EUR);
        }

        public List<string[]> GetConversionInformation()
        {
            return ConversionInfo;
        }
        
    }
}
