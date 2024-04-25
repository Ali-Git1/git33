using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                CustomArraylist<string> customList = new CustomArraylist<string>(5);

                
                customList.Add("alma");
                customList.Add("banan");
                customList.Add("mandarin");
                customList.Add("Mango");
                customList.Add("uzum");

                string[] moreFruits = { "alma", "yemis", "fruit" };
                customList.AddRange(moreFruits);

                
                customList.Remove("banan");

                
                customList.RemoveAt(3);

               
                customList.TrimToSize();

               
               
                for (int i = 0; i < customList.Count; i++)
                {
                    Console.WriteLine(customList.array[i]);
                }

                Console.ReadLine();
            }
        }

    
}

