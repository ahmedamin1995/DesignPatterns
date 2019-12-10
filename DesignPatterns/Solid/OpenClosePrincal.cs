using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    class OpenClosePrincal
    {
    }
    

    public enum size
    {
        small,
        midium,
        large
    }

    public enum color
    {
        red,blue ,green
    }
public class Product
    {
        public Product(string name, color color, size size)
        {
            Name = name;
            this.color = color;
            this.size = size;
        }

        public string Name { get; set; }

        public color  color { get; set; }
        public size size { get; set; }
    }

    public interface ISpesifactions<T>
    {
        bool IsSatified(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> filter(IEnumerable<T> item, ISpesifactions<T> spec);
    }

    public class ColorSpesifactions : ISpesifactions<Product>
    { 
        color color;

        public ColorSpesifactions(color color)
        {
            this.color = color;
        }

        public bool IsSatified(Product product)
        {
            return product.color == this.color;
        }
    }

    public class SizeSpesifactions : ISpesifactions<Product>
    {
        size size;

        public SizeSpesifactions(size size)
        {
            this.size = size;
        }

        public bool IsSatified(Product product)
        {
            return product.size == this.size;
        }
    }


    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> filter(IEnumerable<Product> item, ISpesifactions<Product> spec)
        {
            foreach (var i in item)
            {
                if (spec.IsSatified(i))
                    yield return i;
            }
        }
    }
}

