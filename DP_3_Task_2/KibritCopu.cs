using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_2
{
    public class KibritCopu : ICloneable
    {
        public KibritCopuQirmiziFosfor? qirmiziFosfor { get; set; }

        public KibritCopuTaxdasi? taxdasi { get; set; }

        public KibritCopu(KibritCopuQirmiziFosfor? qirmiziFosfor, KibritCopuTaxdasi? taxdasi)
        {
            this.qirmiziFosfor = qirmiziFosfor;
            this.taxdasi = taxdasi;
        }

        public object Clone()
        {
            return new KibritCopu(new KibritCopuQirmiziFosfor(qirmiziFosfor!.Miqdar), new KibritCopuTaxdasi(taxdasi!.uzunluq, taxdasi!.enliliy));
        }
    }
}
