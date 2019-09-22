﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Rodrigo");
            studentRecords.Add("Maria");
            studentRecords.Add("João");
            studentRecords.Add("Carlos");
            studentRecords.Add("Ana");

            studentRecords.SetSortStategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
