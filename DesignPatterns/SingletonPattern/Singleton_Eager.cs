using System;

namespace DesignPatterns.SingletonPattern
{
  public sealed  class  Singleton_Eager
    {
        private static int counter = 0;
        private static readonly Singleton_Eager instant = new Singleton_Eager();
        private static readonly object obj = new object();
        public static Singleton_Eager Getinstant
        {
            get
            {
                
                return instant;
            }
            

        }
        private Singleton_Eager()
        {
            counter++;
            Console.WriteLine("Counter value is"+ counter.ToString());

        }

        public void print(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
