using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6CalssDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person tom = new Person();
            tom._name = "Tom";
            tom._age = 25;
            tom._gender = "male";
            tom.Speak();
            tom.Drive();

            Person jerry = new Person();
            jerry._name = "Jerry";
            jerry._age = -28;
            jerry._gender = "Spring";
            jerry.Speak();
            jerry.Drive();





            Console.ReadLine();



        }
    }

    
}
