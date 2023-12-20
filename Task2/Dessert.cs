using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Dessert : Dish
    {
        protected string _taste;
        
        public Dessert(string name, double price,string taste) : base(name, price)
        {
            this._taste = taste;
        }
    }
}
