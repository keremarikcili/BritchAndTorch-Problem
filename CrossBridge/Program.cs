using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossBridge
{
    class Program
    {
        public static int TotalTime(List<int> band, int n)
        {
            if (n < 3)
            {
                 
                Console.WriteLine("Son hamle maliyeti  : "+Math.Min(band[n-1],band[n-2]));
                return band[n - 1]; // 2 || 1  
            }
            else if (n == 3)
            {

                Console.WriteLine("{0} için hamleler ", band[2]);
                Console.WriteLine("1. hamle maliyeti  :"+ band[2]);
                Console.WriteLine("{0} ve {1} karşıya geçti", band[0], band[2]);
                Console.WriteLine("2. hamle maliyeti :"+ band[0]);
                Console.WriteLine("{0} geri döndü.", band[0]);
                Console.WriteLine("Son hamle maliyeti  : " +  band[1] );
                Console.WriteLine("{0} ve {1} karşıya geçti.Ve oyun bitti.",band[1],band[0]);



                return band[0] + band[1] + band[2]; 
            }
            else
            {
                int temp1 = band[n - 1] + band[0] + band[n - 2] + band[0]; //  
                int temp2 = band[1] + band[0] + band[n - 1] + band[1]; //  

                if (temp1 < temp2)
                {
                    return temp1 + TotalTime(band, n - 2);
                }
                else if (temp2 < temp1)
                {
                    Console.WriteLine("{0} ve {1} için hamleler ", band[n - 1], band[n - 2]);

                    Console.WriteLine("ilk hamle maliyeti : " + band[1]);
                    Console.WriteLine("{0} ve {1} karşıya geçti", band[0],band[1]);
                    Console.WriteLine("2. hamle maliyeti: "+band[0]);
                    Console.WriteLine("{0} geri döndü.", band[0]);
                    Console.WriteLine("3. hamle maliyeti: "+band[n-1]);
                    Console.WriteLine("{0} ve {1} karşıya geçti", band[n-1], band[n-2]); 
                    Console.WriteLine("4. hamle maliyeti: "+band[1]);
                    Console.WriteLine("{0} geri döndü.", band[1]);
                    return temp2 + TotalTime(band, n - 2);
                }
                else
                {
                    Console.WriteLine("UYARI BÜTÜN DEGERLER BİRBİRİNE ESİT !");
                    Console.WriteLine("{0} ve {1} için hamleler ", band[n - 1], band[n - 2]);

                    Console.WriteLine("ilk hamle maliyeti : " + band[1]);
                    Console.WriteLine("{0} ve {1} karşıya geçti", band[0], band[1]);
                    Console.WriteLine("2. hamle maliyeti: " + band[0]);
                    Console.WriteLine("{0} geri döndü.", band[0]);
                    Console.WriteLine("3. hamle maliyeti: " + band[n - 1]);
                    Console.WriteLine("{0} ve {1} karşıya geçti", band[n - 1], band[n - 2]);
                    Console.WriteLine("4. hamle maliyeti: " + band[1]);
                    Console.WriteLine("{0} geri döndü.", band[1]);

                    return temp2 + TotalTime(band, n - 2);
                }
            }
        }

        static void Main(string[] args)
        {
            // change the no of people crossing the bridge
            // add or remove corresponding time to the list
            int n = 5;

            List<int> band = new List<int>() { 1,3,6,8,12};

            band.Sort();

            Console.WriteLine("The total time taken to cross the bridge is: " + Program.TotalTime(band, n));
            Console.ReadLine();
        }
    }
}
