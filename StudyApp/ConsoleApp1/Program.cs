// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
const float pi = 3.14f;
const int o = 1;

testreadony emp= new TestAbstract();
//emp.FirstName = "Pranaya";
//emp.LastName = "Rout";
//emp.Register();
SealedClassexp d = new SealedClassexp();
d.getdata();
d.Add(1,2);
NormalClasscs c = new NormalClasscs();
c.getdata();

Normal2 s = new Normal2();
s.getdatass();


emp.Register();
Console.WriteLine(emp.ToString());
Console.ReadKey();
