using System.ComponentModel.DataAnnotations;

namespace Assignment103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 5, 7 };
            int length = myArray.Length;
            int temp = 0;
            
            for (int i = 0; i < (length / 2); i++)
            {
                temp = myArray[i];
                myArray[i] = myArray[length -1-i];
                myArray[length-1-i] = temp;
            }
            
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }

    }
}

