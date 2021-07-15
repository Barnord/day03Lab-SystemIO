using System;
using System.IO;

namespace SystemIOChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ThreeProduct();
            //ReturnAverageEnvelope();
            //Challenge3();
            //Challenge4();
            //Challenge5();
            //Challenge6();
            //Challenge7();
            Challenge8();
            //Challenge9();
        }

        static int ThreeProduct()
        {
            Console.WriteLine("Please enter three numbers with spaces inbetween.");
            string[] stringArr = Console.ReadLine().Split(" ");

            int ans = 1;

            for (int i=0; i<=2; i++)
            {
                try
                {
                    int currentNum = (Convert.ToInt32(stringArr[i]));
                    ans = ans*currentNum;
                }
                catch (IndexOutOfRangeException)
                {
                    ans = 0;
                }
            }
            Console.WriteLine(ans);
            return ans;
        }

        public static void ReturnAverageEnvelope()
        {
            Console.WriteLine("Please enter a number between 2 and 10.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int[] numberArr = new int[userNumber];
            int length = numberArr.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Please enter a number: {i} of {length}");
                numberArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int feedback = ReturnAverage(numberArr);
        }
        //Where the math lives
        public static int ReturnAverage(int[] arrayIn)
        {
            int length = arrayIn.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += arrayIn[i];
            }
            int average = sum / length;
            Console.WriteLine($"The average of these {length} numbers is: {average}");
            return average;
        }

        public static void Challenge3()
        {
            Console.Write("    * \n\n   *** \n\n  *****\n\n *******\n\n*********\n\n *******\n\n  *****\n\n   ***\n\n    * ");
        }

        public static int Challenge4(int[] arr)
        {
            int[] ansArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int ans = 0
                ;
            for (int i = 0; i < arr.Length; i++)
            {
                ansArr[arr[i]]++;
            }
            for (int i = 1; i<ansArr.Length; i++)
            {
                if (ansArr[i]>ansArr[i-1])
                {
                    ans = i;
                }
            }
            Console.WriteLine(ans);
            Console.ReadLine();
            return ans;
        }

        public static int Challenge5(int[] arr)
        {
            int ans = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    ans = arr[i];
                }
            }
            return ans;
        }

        public static void Challenge6()
        {
            string docPath = "../../../words.txt";
            Console.WriteLine("Please enter a word or phrase to enter into the words.txt document.");
            string phrase = Console.ReadLine();

            File.AppendAllText(docPath, phrase);
        }

        public static void Challenge7()
        {
            string docPath = "../../../words.txt";
            string goodWords = File.ReadAllText(docPath);
            Console.WriteLine(goodWords);
        }

        public static void Challenge8()
        {
            string docPath = "../../../words.txt";
            string oldWords = File.ReadAllText(docPath);
            Console.WriteLine(oldWords);
            Console.WriteLine("Please enter a word from above to remove, and rewrite at the end of the file.");
            string badWord = Console.ReadLine();
            string newWords = oldWords.Replace(badWord, "");
            File.WriteAllText(docPath, newWords + badWord);
        }

        public static string[] Challenge9()
        {
            Console.WriteLine("Give me words.");
            string wordsDemanded = Console.ReadLine();
            string[] eachWord = wordsDemanded.Split(" ");
            string[] answers = new string[wordsDemanded.Length];
            for (int i = 0; i<eachWord.Length; i++)
            {
                answers[i] = $"{eachWord[i]}: {eachWord[i].Length}";
            }
            for (int i = 0; i<answers.Length; i++)
            {
                Console.WriteLine(answers[i]);
            }

            return answers;
        }
    }
}
