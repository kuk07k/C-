﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Add(params int[] values)
        {
            int result = 0;

            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }

