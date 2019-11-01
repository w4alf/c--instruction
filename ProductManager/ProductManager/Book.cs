using System;

namespace ProductManager
{
    class Book: Product
    {
      public String Author { get; set; } 
        
      public  Book(string c, string d, double p, string a): base(c, d, p)
        {
            Author = a;
        }
    
            

    }
}
