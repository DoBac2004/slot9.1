﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot9.a2
{
   
     
class IndexerExample
        {
            public int[] intList = new int[10];
            public int this[int index]
            {
                get { return intList[index]; }


                set { intList[index] = value; }
            }
        }
        
 class Program
    {
            static void Main()
            {
                int i, j = 0;
                IndexerExample indexTest = new IndexerExample();
                for (i = 1; i < 10; i += 2)
                {
                    indexTest[j] = i;
                    j++;
                }
                for (i = 0; i < 5; i++)
                    Console.WriteLine("indexTest[{0}] is {1}", i, indexTest[i]);
                Console.ReadLine();
            }
        }

    }

