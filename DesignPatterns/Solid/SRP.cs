using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    public class SRP
    {
    }

    public class journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public void AddEntries(string text) => entries.Add($"text: {text} ,{++count}");

        public void RemoveEntries(int index) => entries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, entries);

    }

    public class Presitance
    {
        public void Save(journal j, string filename) => File.WriteAllText(filename, j.ToString());
    }
}