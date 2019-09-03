using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Letter between A and Z");

            var entered = Console.ReadLine();
            char charEntered = char.Parse(entered);

            if (!char.IsLetter(charEntered))
            {
                Console.WriteLine("\nInvalid entry, please enter a Letter between A and Z");
                Console.ReadLine();
            }
            else
            {
                var shape = PrintTheShape(charEntered);
                Console.WriteLine(shape);
                Console.ReadLine();
            }
            Console.WriteLine("");
        }

        public static string PrintTheShape(char keyEntered)
        {
            // GET THE INPUT   
            Console.WriteLine("");

            StringBuilder sb = new StringBuilder();

            //array of strings
            char[] ListOfAlphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
            int LetterCount = 0;
            string[] LetterArray = new string[2 * ListOfAlphabet.Length];

            //search for letter number in the array 
            for (int i = 0; i < ListOfAlphabet.Length; i++)
            {
                if (ListOfAlphabet[i] == keyEntered)
                {
                    LetterCount = i;
                    break;
                }
            }

            for (int i = 0; i <= LetterCount; i++)
            {

                for (int j = 0; j < LetterCount - i; j++)
                {
                    LetterArray[i] += " ";
                }

                LetterArray[i] += ListOfAlphabet[i];

                if (ListOfAlphabet[i] != 'a')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        LetterArray[i] += " ";
                    }

                    LetterArray[i] += ListOfAlphabet[i];
                }

                sb.AppendLine(LetterArray[i]);
            }

            for (int i = LetterCount - 1; i >= 0; i--)
            {
                sb.AppendLine(LetterArray[i]);
            }
            return sb.ToString();
        }
    }
}