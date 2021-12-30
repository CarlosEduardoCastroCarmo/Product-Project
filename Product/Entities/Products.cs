using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Product.Entities
{
    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {
        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " " + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
