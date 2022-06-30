using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Q3_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter The Number of Elements You want to enter ");
            int len = Convert.ToInt32(Console.ReadLine());

            List<int> nonprime = new List<int>();
           
            int [] arr = new int[len];
            int[]  nonprimearr = new int[len];

            for (int x=0;x<arr.Length;x++)   // Taking Input 
            {
                Console.WriteLine("Enter Number at " + x + " = ");
                arr[x] = Convert.ToInt32(Console.ReadLine());
            }

            for (int z = 0; z < arr.Length; z++)   // Output
            {
                Console.WriteLine("Number at Index " + z + " = " + arr[z]);
                
            }


            bool isprime; ;
            Console.WriteLine("");

            for (int i = 0; i < arr.Length; i++)   // Prime Number Loop 
            {
                if (arr[i]==0 || arr[i]==1)
                {
                    Console.WriteLine(arr[i] + " is not a Prime Number ");
                   
                }

                else 
                {
                    isprime = true;

                    for (int j = 2; j <=arr.Length / 2 ; j++)
                    {
                        if (arr[i] % j == 0)
                        {

                            Console.WriteLine(arr[i] + " Is Not a Prime Number");
                            nonprimearr[i] = arr[i];
                            isprime = false;
                            break;


                        }

                        else if (isprime == true)
                        {
                            Console.WriteLine(arr[i] + " is a prime number");

                        }
                    }
                
                }

            }

            Console.WriteLine("\nArray of Non Prime Numbers\n");
            nonprimearr = nonprimearr.Where(e => e != 0).ToArray();
            Console.WriteLine(String.Join(",", nonprimearr));

            

            Console.ReadLine();
        }
    }
}
