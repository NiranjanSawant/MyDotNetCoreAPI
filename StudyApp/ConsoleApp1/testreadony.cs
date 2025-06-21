using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract  class testreadony
    {
        //public string FirstName;
        //public string LastName;
        //Overriding the Virtual ToString method of Object class
        //Overriding the Virtual method using override modifier
        //public override string ToString()
        //{
        //    return FirstName + ", " + LastName;
        //}

        //static void Main(string[] args)
        //{
        //    testreadony emp = new testreadony();
        //    emp.Register();
        //    Console.WriteLine("Main method");
        //    Console.ReadKey();
        //}
        //private testreadony()
        //{
        //    Console.WriteLine("static constructor called..");
        //}
       
       
        public  void Register()
        {
            //return 0;
            getdata();
            Savedata();
        }

        private void getdata()
        {

        }

        private void Savedata()
        {

        }
        public abstract void Testab();
      

        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }

        private void testprbv()
        {
            Console.WriteLine($"Subtraction ");
        }

    }
}
