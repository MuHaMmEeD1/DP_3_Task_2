

using DP_3_Task_2;

namespace Task2
{

    class Program
    {

        static void Main(string[] args)
        {
            FacadeKibritQutusu facadeKibritQutusu = new();

            KibritQutusu kibritQutusu = facadeKibritQutusu.KibritQutusuAl();

            kibritQutusu.KibritCopuSayiniBax();
            kibritQutusu.KibritiCopuYandir();
            kibritQutusu.KibritCopuSayiniBax();

        }

    }


}