using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._2023
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }
        static void EndIfNotInt(string s, out int o, int code)
        {
            if (!(int.TryParse(s, out o))) EndErr(code);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter exempl str: ");
            var str = new StringBuilder(Console.ReadLine());

            #region Task 8
            //Console.Write("Enter index: ");
            //EndIfNotInt(Console.ReadLine(), out int index, 8);
            //str.Remove(index, 1);
            #endregion

            #region Task 9
            //Console.Write("Enter substr: ");
            //string substr = Console.ReadLine();
            //str.Replace(substr, "");
            #endregion

            #region Task 10
            //Console.Write("Enter substr: ");
            //string substr = Console.ReadLine();
            //Console.Write("Enter index: ");
            //EndIfNotInt(Console.ReadLine(), out int index, 10);
            //str.Insert(index, substr);
            #endregion

            #region Task 11
            //bool result = true;
            //for (int i = 0; i < str.Length; i++)
            //    if (str[i] != str[str.Length - i - 1])
            //    { 
            //        result = false;
            //        break;
            //    }
            //Console.WriteLine(result ? "It's a palindrome" : "It's not a palindrome");
            #endregion

            #region Task 12
            //Console.WriteLine($"Qty words: {str.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length}");
            #endregion

            #region Task 13
            //Console.Write("Enter find: ");
            //string findstr = Console.ReadLine();
            //Console.Write("Enter replace: ");
            //string repstr = Console.ReadLine();
            //str.Replace(findstr, repstr);
            #endregion

            #region Task 14
            //string[] word = str.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //str.Clear();
            //for (int i = word.Length - 1; i >= 0; i--) str.Append(word[i] + ' ');
            #endregion

            #region Task 15
            //char[] Ends = {
            //    'у',
            //    'е',
            //    'а',
            //    'о',
            //    'и',
            //};

            //string[] words = str.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //int answer = 0;
            //foreach (string word in words)
            //    foreach (char c in Ends)
            //    {
            //        if (word.Last() == c)
            //        {
            //            answer++;
            //            break;
            //        }
            //    }

            //Console.WriteLine($"Answer: {answer}");
            #endregion

            Console.WriteLine($"Result: {str}");
            Console.ReadKey();
        }
    }
}
