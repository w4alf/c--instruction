using System;

namespace ProductManager
{
    class Product
    {
        public String Code { get; set; }

        public String Description { get; set; }

        public double Price { get; set; }

        public Product()
        {
                
        }

        public Product(string c, string d,  double p)
        {
            Code = c;
            Description = d;
          
            Price = p;

        }

        public override string ToString()
        {
            return "code= " + Code + " description " + Description + " price "+ Price.ToString("C2");
        }


    }
}
