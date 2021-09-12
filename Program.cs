using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // int maxNum = GetMax(3, 5);
            // Console.WriteLine(maxNum);

            // int maxNumm = GetMaxxi(3, 6, 7);
            // Console.WriteLine(maxNumm);
            // Simple Guess Game

           //call guesser
          //Guesser();

            // statistics mean calculator
            // int[] nums = {2, 4, 7, 5, 6, 7, 10, 78};

            // double result = MeanCalc(nums);
            // Console.WriteLine(result);

            //multi dimensional array 
            int[, ] multiNums = new int[3, 2] {
                {2, 3},
                {4, 5},
                {6, 7}
            };

            // 👇 - customArr is instantied strictly with 2 elements and 
            // 3 elements inside those to parent elements i.e {{1, 3, 6}, {2, 6, 9}}
            // int[,] customArr = new int[2, 3];

            // Looping through a multidimensional array
           foreach (var item in multiNums)
           {
               System.Console.Write($"{item} ");
           }

            // Console.WriteLine(multiNums[0, 1]);
            
        }

        static int GetMax(int num1, int num2) {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }else {
                result = num2;
            }

            return result;
        }

        static int GetMaxxi(int num1, int num2, int num3) {
            int result;

            if (num1 >= 2 && num1 >= num3)
            {
                result = num1;
            }else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }else
            {
                result = num3;
            }

            return result;
        }

        static void Guesser() {

            string guessWord = "duixe";
            string answer = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfguesses = false;
            
            do
            {   
                if (guessLimit >= guessCount)
                {
                    Console.Write("Enter the word: ");
                    answer = Console.ReadLine();
                    guessCount++;
                }else
                {
                    outOfguesses = true;
                }
                
            } while (answer != guessWord && !outOfguesses);

            if (outOfguesses)
            {
                Console.WriteLine("You Lose");
            }else
            {

                Console.WriteLine("Congrats you guess the word");
    
            }
        }

        static float MeanCalc(int[] nums) {

            float result;
            int length = nums.Length;
            int sum = 0;

            for (var i = 0; i < length; i++) {
                sum += nums[i];
            }
            
            result = sum / length;

            return result;
            
        }
    }
}
