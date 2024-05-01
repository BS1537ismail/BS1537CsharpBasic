﻿using BS1537CsharpBasic;
using System;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace BS1537CsharpBasic
{
    internal class Program
    {
        //enum
        public enum Months
        {
            January,
            February,
            March = 6,
            April,
            May,
            June
        }
        public static void Main(string[] args)
        {

            //Typer Casting
            string std = "100";
            int std_int = int.Parse(std);
            Console.WriteLine(std_int);
            //Exception block
            try
            {
                int val = 10000;
                byte val_byte = Convert.ToByte(val);
                Console.WriteLine(val_byte);
            }
            catch (Exception)
            {
                Console.WriteLine("Number cannot convert properly");
            }
            //Class
            Person Ismail = new Person();
            Ismail.firstName = "Ismail";
            Ismail.lastName = "Hosen";
            Ismail.Introduce();
            //calculator
            Calculator calculator = new Calculator();
            int addition = calculator.Add(1, 3);
            Console.WriteLine(addition);
            //Array
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //enum
            int monthNumber = (int)Months.March;
            Console.WriteLine(monthNumber);


        }
    }
}