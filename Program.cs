using System;

namespace PredictArrayOutput
{
    class Program
    {
        public static void Main(string[] args)
        {
            String[] str = new String[] { "Sunflower", "Rose", "Jasmine", "Marigold", "Lily", "Lotus" };
            String[] Info = str;
            foreach (string k in Info)
            {
                Console.WriteLine(k[2]);
            }

        }
    }

//op:
//n
//s
//s
//r
//l
//t

}
