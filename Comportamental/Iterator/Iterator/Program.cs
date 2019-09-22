﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator i = a.createIterator();

            Console.WriteLine("Interagindo com a comlegação");

            object item = i.First();

            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
