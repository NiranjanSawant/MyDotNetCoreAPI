using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestAbstract: testreadony
    {
        public override void Testab()
        {
            Console.WriteLine("Hello, World!");

        }

        SealedClassexp s = new SealedClassexp();
      

        //SealedClassexp ds = new SealedClassexp();
        //ds.Add(1, 2);
    }
}
