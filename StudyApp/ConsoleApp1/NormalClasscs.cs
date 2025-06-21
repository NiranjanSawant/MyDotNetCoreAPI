using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NormalClasscs: TestMulInher
    {


        public  override void getdata()
        {
           
        }


    }

    public class Normal2 : NormalClasscs
    {


        public sealed override void getdata()
        {

        }

    }

    public partial class P1
    {
        public string p1a { get; set; }
    }

    public partial class P1
    {
        public string p2a { get; set; }
    }
}
