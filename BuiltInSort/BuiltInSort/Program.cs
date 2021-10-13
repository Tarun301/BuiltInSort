using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInSort
{
    class BuiltInSort 
    {
        private string Category;

        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                        "Id: " + arr[i].Id + ", "
                        + "Name: " + arr[i].ItemName + ", "
                        + "Category: " + arr[i].Category);
            Console.WriteLine();
           
        }

        static void Main(string[] args)
        {
            BuiltInSort ob = new BuiltInSort();

            CatalogueItem[] arr = {
            new CatalogueItem( 3, "Life of Pi","Books"),
            new CatalogueItem( 7, "Deelongie 4 way toaster","Home and Kitchen"),
            new CatalogueItem( 2, "Glorbarl knife set","Home and Kitchen"),
            new CatalogueItem( 4, "Diesorn vacuum cleaner","Appliances"),
            new CatalogueItem( 5, "Jennie Olivier sauce pan","Home and Kitchen"),
            new CatalogueItem( 6, "This book will save your life","Books"),
            new CatalogueItem( 9, "Kemwould hand mixer","Appliances"),
            new CatalogueItem( 1, "Java for Dummies","Books"),
        };
            Console.WriteLine("The Unsorted array is\r\n");
            ob.PrintArray(arr);

            //apply sort
            Array.Sort(arr);
            Console.WriteLine("The array sorted by category Name using C# built in sort is:\r\n");
            
            ob.PrintArray(arr);

            Console.WriteLine("For this particular program, According to me Built in Sort Algorithm is more \r\n" +
                " efficient than the Bubble Sort.Because, Bubble sort has worst-case and average complexity both O(n2), where n \r\n" +
                "is the number of items being sorted. Whereas, Built in Sort is stable and doesnot change the relative order of \r\n" +
                "elements with equal keys.It only requires a constant amount O(1) of additional memory space. ");

            Console.Read();





        }

    }
}
