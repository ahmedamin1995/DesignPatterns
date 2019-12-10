using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    class DIP
    {
    }
   

    public enum Realationships
    {
        parent,
        child
    }
    public class Person
    {
        public string Name { get; set; }
    }

   public interface IRealations
    {
        IEnumerable<Person> FindAll(string name);
    }
    public class Realation: IRealations
    {
       
        
      
        public Realation()
        {
                
        }
      private  List<(Person, Realationships, Person)> persons = new List<(Person, Realationships, Person)>();
        private IRealations _realations;

        public void AddpersonChild(Person parent,Person child)
        {
            persons.Add((parent, Realationships.parent, child));
            persons.Add((child, Realationships.parent, parent));

        }

        public IEnumerable<Person> FindAll(string name)
        {
            return persons.Where(x => x.Item1.Name == name && x.Item2 == Realationships.parent).Select(p => p.Item3);
        }

       
    }
}
