using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_2
{
    public class KibritQutusu
    {
        public int KibritCopuSayi { get; set; }
        public List<KibritCopu> kibritCopus { get; set; } = new List<KibritCopu>();

        public KibritQutusu(KibritCopu kibritCopu , int kibritCopuSayi = 25)
        {
            KibritCopuSayi = kibritCopuSayi;

            for (int i = 0; i < KibritCopuSayi; i++)
            {
                kibritCopus!.Add((KibritCopu)kibritCopu.Clone());
            }

           
        }

        public void KibritiCopuYandir()
        {
            if(KibritCopuSayi != 0) {
                KibritCopuSayi--;
                kibritCopus.RemoveAt(kibritCopus.Count - 1);

                Console.WriteLine("KibritCopu Yandi");
            }
            else { Console.WriteLine("KibritCopu yoxdu"); }
            
        }


        public void KibritCopuSayiniBax()
        {
            Console.WriteLine(KibritCopuSayi);
        }





    }
}
