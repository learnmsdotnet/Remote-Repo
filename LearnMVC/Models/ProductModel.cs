using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LearnMVC.Models
{
    public class ProductModel
    {
        //inside this model class we will add properties respective to our table(Product) column

        public int ID { get; set; }

        [DisplayName("Product Name")]
        public string Name{ get; set; }

        public decimal Price{ get; set; }

        public DateTime Date { get; set; }
    }
}