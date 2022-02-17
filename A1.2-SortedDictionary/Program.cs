using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted
                = new SortedDictionary<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17654));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine("Pressione qualquer tecla para continuar. . . ");
            Console.ReadLine();
        }
    }
}
