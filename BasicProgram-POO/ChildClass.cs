using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram_POO
{
    internal class ChildClass : AbsClass
    {
        //ChildClass ejemplillo = new ChildClass();

        protected override void method1() 
        {
            Console.WriteLine("ejecutando metodo 1");
        }
        protected override void method2() 
        {
            Console.WriteLine("ejecutando metodo 2");
        }
        

    }
}
