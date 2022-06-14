using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton2
    {
        private static Object lockOgbect = new Object();
        private static Singleton2 instance;

        private Singleton2() 
        {
            MyProperty++;
        }

        public static Singleton2 Instance 
        {
            get 
            {
                if (instance == null)
                {
                    lock (lockOgbect)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }
                return instance; 
            } 
        }

        public int MyProperty { get; set; }
    }
}
