using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine(10, '*'); Console.WriteLine();
            VLine(10, 'a'); Console.WriteLine();
            HLine(10, 'b'); Console.WriteLine();
            DLine(10, '*');
        }

        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }
        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }
        // idea: first line draw 0 space and 1 star
        // idea: second line draw 1 space and 1 star
        // idea: third line draw 2 spaces and 1 star
        // idea: last 
        static void DLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(i, ' ');
                Console.WriteLine(" " + c);
            }
        }
        
        // first line: n-1 spaces, 1 star
        // second line: n-2 spaces, 1 star, 1 space, 1 star
        // third line: n-3 spaces, 1 star, 3 spaces, 1 star
        // fourth line: n-4 spaces, 1 star, 5 spaces, 1 star
        // last line: 2n-1 stars
  
        static void DrawTriagle(int n, char c)
        { 
            // first line
            HLine(n - 1, ' '); HLine(1, '*'); Console.WriteLine();
            for (int i = 0; i < n; i++ )
                // fourth line
                int a = 2, b = 1;
                for (int i = 0; i < n - 2; i++)
                {
                    HLine(n - a, ' '); HLine(1, c);     Console.WriteLine();
                    HLine(b, ' ');      HLine(1, c);    Console.WriteLine();
                  
                // ith line 
                    a = a + 1;
                    b = b + 2;
                }
                // last line
                HLine(2 * n - 1, '*'); Console.WriteLine();
            
        }
    }
}

