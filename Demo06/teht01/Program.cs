﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"d:\k1625\test.txt");
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access to the path 'c:\test.file' is denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile == null)
                {
                    outputFile.Close();
                }
            }
            bool run = true;
            string input = "";
            while (run==true)
            {
                Console.WriteLine("Give a line (end by typing quit) : ");
                input = Console.ReadLine();
                if (input.ToLower()=="quit")
                {
                    run = false;
                    break;
                }
                outputFile.WriteLine(input);
            }
            outputFile.Close();
        
        }
    }
}
