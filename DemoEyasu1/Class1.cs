﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEyasu1
{
    class Class1
    {
        static void main(string[] args)
        {
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;

            var result = numbers[0];
            result = result + numbers[1];
            result = result + numbers[2];
            Console.WriteLine(result);

        }







    }
}

