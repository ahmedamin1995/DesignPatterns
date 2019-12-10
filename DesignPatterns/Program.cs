using DesignPatterns.FactoryPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.Solid;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
namespace DesignPatterns
{
    class Program
    {
        

        //public Program(IRealations realations)
        //{
        //    foreach (var item in realations.FindAll("Amin"))
        //    {
        //        Console.WriteLine($"Amin has Child{item.Name}");
        //    }
        //}
       

        static void Main(string[] args)
        {
            // DesignPatterns

            #region Singleton
            //Singleton DesignPattern
            //        Parallel.Invoke(
            //      () => Ahmed(),

            //      () => AhmedAmin()
            //    );


            //    }

            //    private static void AhmedAmin()
            //    {
            //        Singleton singleton1 = Singleton.Getinstant;
            //        singleton1.print("ahmed amin");
            //    }

            //    private static void Ahmed()
            //    {
            //        Singleton singleton = Singleton.Getinstant;
            //        singleton.print("ahmed");

            #endregion

            #region Factory 
            //// Factory Method DesignPattern
            ///


            //var factory = new Point().ExecuteCreation(CoordinatSytem.Cartesian, 2, 3);
            //factory.GetPoint();

            #endregion

            #region Builder

            #endregion
            //  SOLID
            #region SRP
            ////var j = new journal();
            ////j.AddEntries("ahmed ");
            ////j.AddEntries("amin");
            ////System.Console.WriteLine(j);
            ////Presitance presitance = new Presitance();
            ////presitance.Save(j, @"C:\Users\ahmed amen\Desktop\journal.txt");
            ////Process.Start(@"C:\Users\ahmed amen\Desktop\journal.txt");

            #endregion
            #region OPP
            //var apple = new Product("apple", color.red, size.small);
            //var tree = new Product("Tree", color.green, size.large);
            //Product[] products = { apple, tree };
            //var BF = new BetterFilter();
            //var p = BF.filter(products, new SizeSpesifactions(size.small));

            //foreach (var item in p)
            //{
            //    System.Console.WriteLine(item.Name);
            //} 
            #endregion

            #region DIP

            //var parent = new Person() { Name="Amin"};
            //var child1 = new Person() { Name = "Yara" };
            //var child2 = new Person() { Name = "Ahmed" };

            //var realation = new Realation();
            //realation.AddpersonChild(parent, child1);
            //realation.AddpersonChild(parent, child2);

            //new Program(realation);


            #endregion

        }

        // adapter

      
    }
}
