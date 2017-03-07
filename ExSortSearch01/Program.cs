using System;
using System.Diagnostics;

namespace ExSortSearch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProg = new Program();
            myProg.Run();
        }

        private void Run()
        {
            int smallSize = 1000;
            int largeSize = smallSize * 10;

            ClubMember[] smallLinear = new ClubMember[smallSize];
            ClubMember[] largeLinear = new ClubMember[largeSize];

            ClubMember[] smallBinary = new ClubMember[smallSize];
            ClubMember[] largeBinary = new ClubMember[largeSize];

            FillArray(smallLinear);
            FillArray(largeLinear);
            FillArray(smallBinary);
            FillArray(largeBinary);

            SearchLinear(smallLinear);
            SearchLinear(largeLinear);

            Console.ReadKey();
        }

        private void SearchLinear(IComparable[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Random rnd = new Random();

            ClubMember[] cmArr = (ClubMember[])arr;

            ClubMember cm1 = cmArr[rnd.Next(0, arr.Length - 1)];
            ClubMember cm2 = cmArr[rnd.Next(0, arr.Length - 1)];
            ClubMember cm3 = cmArr[rnd.Next(0, arr.Length - 1)];

            int index = 0;
            
            for (int i = 0; i < 1000; i++)
            {
                index = 0;
                while (cm1.Equals(arr[index]) == false)
                {
                    index++;
                }
                index = 0;
                while (cm2.Equals(arr[index]) == false)
                {
                    index++;
                }
                index = 0;
                while (cm3.Equals(arr[index]) == false)
                {
                    index++;
                }
            }
            sw.Stop();
            Console.WriteLine("Linear Search(" + arr.Length + "): " + sw.Elapsed);
        }

        private void FillArray(ClubMember[] arr)
        {
            for(int i =0; i<arr.Length;i++)
            {
                arr[i] = CMFactory.GetClubMember();
            }
        }
    }
}
