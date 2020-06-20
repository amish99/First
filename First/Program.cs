using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom", 40);

            tom.sayshello();

            string tomString = tom.ToString();

            Console.WriteLine(tomString);
            Console.WriteLine();


            Person jacky = new Person("Jacky", 22);

            jacky.sayshello();

            Console.WriteLine(jacky.ToString());
            Console.WriteLine();

            /*Student joss = new Student("Joss", 22, "A1234567890");

            joss.SaysHello();
            joss.Studies();

            Console.WriteLine(joss.ToString());


            // wait for user to enter anything*/
            Console.ReadLine();
        }
    }
}
