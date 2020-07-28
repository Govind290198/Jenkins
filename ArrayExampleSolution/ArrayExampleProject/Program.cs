using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleProject
{
    class Program
    {
        //int num1, num2, num3, num4;
        //int[] numbers = new int[4];
        int[] numbers;
        Program()
        {
            int size = 0;
            Console.WriteLine("Enter the numbers");
            size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];
        }

        public void TakeNumbersFromUSer()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number{0}", (i + 1));
                while (!Int32.TryParse(Console.ReadLine(), out numbers[i])) ;
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void PrintAllNumbers()
        {
            /* for (int i = 0; i < 4; i++)
             {
                 Console.WriteLine(numbers[i]);
            
        }*/
        

            
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


        }

        void SortArray()
        {
            int temp = 0;
            for (int i=0;i<numbers.Length;i++)
            {
                for (int j=0;j<numbers.Length-1;j++)
                {
                    if(numbers[j]>numbers[j+1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                    
                }
            }
        }

        static void Main(string[] args)
        {
                Program program = new Program();
                program.TakeNumbersFromUSer();
                program.PrintAllNumbers();
                Console.ReadKey();
        }
    }
}
