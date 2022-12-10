﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Constructor1
    {
        public Constructor1()
        {
            Console.WriteLine("Default constructor");
        }

        // Paramitrized constructor
        public Constructor1(int phone)
        {
            Console.WriteLine("Parameterized constructor");
        }


        // Local variable - Scope is only to the method
        public static void StudentAge(int phoneNumber)
        {
            int age = 0;
            age = age + 10;
            Console.WriteLine("Student age is {0} and phoneNumber is {1}: ", age, phoneNumber);
        }

    }
}
