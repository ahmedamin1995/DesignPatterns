using System;

namespace DesignPatterns.SingletonPattern
{
  public sealed  class Singleton_Lazy
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton_Lazy> instant = new Lazy<Singleton_Lazy>(()=>new Singleton_Lazy());
        private static readonly object obj = new object();
        public static Singleton_Lazy Getinstant
        {
            get
            {
                
                return instant.Value;
            }
            

        }
        private Singleton_Lazy()
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
