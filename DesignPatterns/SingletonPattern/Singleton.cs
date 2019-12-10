using System;

namespace DesignPatterns.SingletonPattern
{
  public sealed  class  Singleton
    {
        private static int counter = 0;
        private static Singleton instant = null;
        private static readonly object obj = new object();
     
        
        public static Singleton Getinstant
        {
            get
            {
                if (instant == null)
                {
                    lock (obj)
                    {
                        if (instant == null)
                        {
                            instant = new Singleton();
                        }
                    }
                }
                return instant;
            }
            

        }
        private Singleton()
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
