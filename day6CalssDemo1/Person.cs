using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6CalssDemo1
{
    class Person
    {
        public string _name;
        public int _age;
        public string _gender;
        
        public void Speak()
        {

            Console.WriteLine("I can talk");
            Console.WriteLine("I am {0},age:{1}, gender:{2}",this._name,this._age,this._gender);
        }

        public void Drive()
        {
            Console.WriteLine("-------Driving---------");
            Console.WriteLine("I can drive");
        }




    }
}