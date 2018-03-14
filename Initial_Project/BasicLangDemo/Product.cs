using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace BasicLangDemo
{    /// <summary>
    /// Manages product
    /// </summary>
    public class Product
    {
        public Product()
        {
            //Console.WriteLine("inside constructor");
        }
        public Product(int productID, string productName, string description) : this()
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Description = description;
            Console.WriteLine("inside parametrised constructor");

        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SayHello()
        {
            return "Hello: " + ProductName + " (" + ProductID + ") " + Description;
        }

        public string StringFunct()
        {
            var dir = @"Insert \n to define a new line";
            
             return dir;

        }


    }
    
    }


