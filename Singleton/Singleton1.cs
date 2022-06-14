using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton1
    {
        private static Singleton1 instance;

        private Singleton1() 
        {
            MyProperty++;
        }

        static Singleton1()
        {
            instance = new Singleton1();
        }

        public static Singleton1 Instance => instance;

        public int MyProperty { get; set; }
    }
}
