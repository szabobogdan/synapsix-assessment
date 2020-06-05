using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j;
            string line;
            string markers;
            Console.WriteLine("Choose the markers: ");
            markers = Console.ReadLine();// it should not contain spaces between markers to work properly
            
           
                      
            System.IO.StreamReader file=new System.IO.StreamReader("intrare.txt");//the input string is read from a file
            Console.WriteLine("Input string: ");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n");

            file.DiscardBufferedData();
            file.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            Console.WriteLine("The string after stripping the text that succedes the markers : ");
            while ((line = file.ReadLine()) != null)// start reading again from the file, from the first line
            {

                for (j = 0; j < markers.Length; j++)
                {
                    i = line.IndexOf(markers[j], 0);
                    if (i != -1)// IndexOf returns -1 in case it doesn't find the character in the string
                    {
                        break;

                    }
                }
                if (i != -1)
                {
                    Console.WriteLine(line.Remove(i));

                }
                else
                {
                    Console.WriteLine(line);
                }


            }
               file.Close();
                       
            Console.ReadLine();
        }
    }
}
