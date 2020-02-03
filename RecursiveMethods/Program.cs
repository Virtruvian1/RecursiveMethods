using System;

namespace RecursiveMethods
{
    class Program
    {
        // Create global variable useInput, which will be called as a condition for multiple Methods
        public static int userInput;
        static void Main(string[] args)
        {
            // Ask for user input : tested 03FEB2020 14:31
            ChoiceOfEquation();
            if (userInput == 1)
            {
                int[] tempArray = CreateArray();
                int sum = SumOfArray(tempArray);
                Console.WriteLine($"The sum of the numbers is: {sum}");
            }
        }

        // Asks for users 1st input : #1 tested 03FEB2020 14:31
        public static int ChoiceOfEquation()
        {
            bool validInput = false;

            do
            {
                // Writes all choices avalible
                Console.WriteLine("Select one of the following:");
                Console.WriteLine("" +
                    "1. Sum of Numbers \r\n" +
                    "2. Assign Letter Grades \r\n" +
                    "3. Average ten scores \r\n" +
                    "4. Average a specific number of scores \r\n" +
                    "5. Average a non-specific number of scores \r\n" +
                    "6. Fibinacci Sequence");
                Console.Write("Input: ");
                userInput = int.Parse(Console.ReadLine());
                // Validates input
                if (userInput >= 1 && userInput <= 6)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input (1-6)");
                } 
            } while (!validInput);
            // Returns userInput
            return userInput;
        }

        // Create array based on n iterations
        public static int[] CreateArray()
        {
            // Initilize Varriables
            bool validInput = false;
            int n = IterationCount(), temp;
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Input Grade { i + 1 } (0-100): ");
                    temp = int.Parse(Console.ReadLine());
                    validInput = Validation(temp);
                    if (validInput == false)
                    {
                        Console.WriteLine("!! Invalid Input !!");
                    }
                    else array1[i] = temp;
                } while (!validInput);
            }
            // Returns a created array of n iterations
            return array1;
        }

        // Create inital size of array, called by CreateArray: #2
        public static int IterationCount()
        {
            // If userInput is 3 allow user to input how many scores
            if (userInput == 3)
            {
                Console.Write("How many grades do you have? ");
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            // If userInput is 6, the array starts at 1 and expands from there based on user input
            else if (userInput == 6)
            {
                return 1;
            }
            else
            {
                return 10;
            }
        }

        // Validates user input for 0 - 100, called by CreateArray: #3
        public static bool Validation(int temp)
        {
            // Pass input from CreateArray after each userInput
            if (temp >= 0 && temp <= 100)
            {
                return true;
            }
            else return false;
            // Returns True if user input is valid
        }

        // Sum numbers of Array
        public static int SumOfArray(int[] array1)
        {
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            return sum;
            // Returns int of the Array summed
        }

        //// Average of numbers of Array
        //public static int AvgOfArray(int[] avgArray)
        //{
        //    // Returns Avg of Array
        //}

        //// Fibinacci Sequence 
        //public static int Fibinacci()
        //{
        //    // Reurns 40th Fibanacci Number
        //}

        //// Compare Average and return letter grade
        //public static char letterGrade(int avg)
        //{
        //    // Returns Char of A, B, C, D, or F based on the score averages
        //}
    }
}
