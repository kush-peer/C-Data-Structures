using System;

namespace Data_Structure
{
    public static class ReverseArray
    {
        public static int[] ReverseArray1(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums.Length - 1 - i];
            }
            Console.WriteLine($"Reverse Array: {string.Join(", ", result)}");
            return result;
        }
    }
}