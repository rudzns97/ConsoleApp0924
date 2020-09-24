using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
   
    class SingleTon1
    {
        static SingleTon1 instance;
        private SingleTon1()
        {

        }

        public static SingleTon1 CreateInstance()
        {
            
            if (instance == null)
                instance = new SingleTon1();

            return instance;
        }
        public void Method()
        {
            Console.WriteLine("메서드 실행");
        }
    }
    class Test
    {
        static void Main()
        {
            SingleTon1 c1 = SingleTon1.CreateInstance();
            c1.Method();

            SingleTon1 c2 = SingleTon1.CreateInstance();
            c2.Method();

            c2 = SingleTon1.CreateInstance();
            c2.Method();
        }
    }
}
