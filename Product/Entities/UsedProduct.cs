using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Product.Entities
{
    class UsedProduct : Products
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " " + "(used) " + "$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ("Manufacture Date: {0}", ManufactureDate));

            return sb.ToString();
        }



    }
}
