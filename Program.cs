using System;
using Data_Structure.Array;
using Data_Structures;

namespace C__Data_Structure
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4,5,110,120};
            int target = 100;
            Console.WriteLine("Welcome to World of Data Structures!");
            Console.WriteLine("----------------Arrays---------------------");
            ArrayStr.ArrayTest();
            ArrayStr.MultiDimensionalArrayTest();
            ArrayStr.JaggedArrayTest();
            int result = ArrayStr.BinarySearch(nums, target);
            Console.WriteLine("Binary Search Result: " + result);
            int converrtedRomanInteger = ArrayStr.ConvertRomantoInteger("MCMCIV");
            Console.WriteLine("Roman To Integer: " + converrtedRomanInteger);

            ReverseString.Reverse(123);
            ReverseString.ReverseInt(-213123123);
        }
    }
}
