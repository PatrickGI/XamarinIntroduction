using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace AwesomeApp
{
    public class Product
    {
        public string name { get; set; }
        public string desc { get; set; }
        //public BitmapImage img { get; set; }
        public string img { get; set; }
    }

    public class ProductList
    {
        public List<Product> product { get; set; }
    }


}
