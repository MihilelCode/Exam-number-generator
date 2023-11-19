using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class Program
    {
        static void Mymothod(string child1, string child2, string child3)
        {
            int i;
            Console.Write("Enter Exam No:");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 123:
                    Console.WriteLine(child1);
                    break;
                case 256:
                    Console.WriteLine(child2);
                    break;
                case 369:
                    Console.WriteLine(child3);
                    break;
                
                    
            }
            
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Mymothod(child3: "Student Name:Lahiru", child2: "Student Name:Mihilel", child1: "Student Name:John");
        }  
        
    }
    
}
