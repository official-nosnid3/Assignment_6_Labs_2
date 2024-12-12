namespace Assignment_6_Labs_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge Labs 6.2
             * 
             * Given an array nums containing n distinct numbers in the range [0, n], 
             * return the only number in the range that is missing from the array.
             * 
             * Use example 3, 0, 1
             * Keep in mind that the array might not be numerically sorted
             */
            
            // An array of natural numbers where the num 5 is missing
            int[] myArray = { 6, 0, 1, 2, 3, 5 };

            // Print the initial information to the user
            Console.WriteLine("The array of numbers below is from the range 0 to n, and it has one missing number");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write($"{myArray[i]} ");

            // Fetch the missing number
            if (myArray.Length + 1 <= myArray.Max())
                Console.WriteLine("\n\nThe given Array has more than one missing number, and therefor does not fit the description of the problem.");
            else
            {
                int missingNum = FindMissingNumber(myArray);

                // Print the missing number
                Console.WriteLine($"\n\nThe missing number is {missingNum}");
                Console.ReadLine();
            }
            
        }

        static int FindMissingNumber(int[] ints)
        {
            
            int max = ints.Max();
            int range = max + 1;
            int givenNumsSum = 0;
            int totalSum = 0; // What the total should be if there wasn't a missing num

            for (int i = 0; i < range; i++)
            {
                if (i < ints.Length)
                    givenNumsSum += ints[i];
                totalSum += i;
            }

            return totalSum - givenNumsSum;
        }
    }
}
