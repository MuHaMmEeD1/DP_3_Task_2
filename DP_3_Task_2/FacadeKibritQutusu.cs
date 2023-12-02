using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_2
{
    public class FacadeKibritQutusu
    {

        
        public KibritQutusu KibritQutusuAl()
        {
            KibritCopuTaxdasi kibritCopuTaxdasi = new KibritCopuTaxdasi();
            KibritCopuQirmiziFosfor kibritCopuQirmiziFosfor = new KibritCopuQirmiziFosfor();
            KibritCopu kibritCopu = new KibritCopu(kibritCopuQirmiziFosfor, kibritCopuTaxdasi);
            return new KibritQutusu(kibritCopu);

        }



    }
}
