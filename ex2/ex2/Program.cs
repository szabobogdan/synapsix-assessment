using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ok = 1;
          
            String input = File.ReadAllText("input.txt");

            int i = 0, j = 0;
            int[,] arr = new int[100, 100];
            //read the structure from a file
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //validating all the conditions
            if(i==j)
            {
                double sr;
                sr = Math.Sqrt(i);
                
                if((sr-Math.Floor(sr)==0))
                {
                    int n = i;
                    for(i=0;i<n;i++)
                    {
                        for(j=0;j<n;j++)
                        {

                            if(arr[i,j]<=0||arr[i,j]>9)
                            {
                                ok = 0;
                                break;
                            }
                         
                        }
                    }
                    
                }
                else
                {
                    ok = 0;
                }
            }
            else
            {
                ok = 0;
            }
            if(ok==0)
            {
                Console.WriteLine("Not a valid Sudoku data structure.");
            }
            else
            {
                Console.WriteLine("Valid Sudoku data structure.");
            }
            Console.ReadLine();
        }
    }
}
