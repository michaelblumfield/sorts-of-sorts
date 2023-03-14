using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[30];
            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-300,300);
            }//generates an unsorted array of 30 random numbers 

            selectionSort(numbers);// sorting the array (will work same with bubble sort)
            
            foreach (int num in numbers)
            {
                Console.WriteLine(num);//frompc and now web
            }
        }
        public static void bubbleSort(int[] numbers)
        {
            foreach(int number in numbers) {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        // if a number is bigger than the next one in the array, it will swap them. it will happen untill the array is sorted
                    }
                }
            }
        }
        public static void selectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                        // the algorithm cecks if there is a bigger number than the given one in the rest of the array and if there is, it will swap them. it will happen untill the array is sorted
                    }
                }
            }
        }
    }
}

