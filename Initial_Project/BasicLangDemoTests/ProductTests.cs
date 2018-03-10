using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicLangDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLangDemo.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        [IgnoreAttribute]
        public void SayHelloTest()
        {
            //arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductID = 1;
            currentProduct.Description = "sharp blade";
            var expected = "Hello: Saw (1) sharp blade";
            //"Hello: " + ProductName + " (" + ProductID + ") " + Description;

            //act
            var actual = currentProduct.SayHello();
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        [IgnoreAttribute]
        public void SayHelloTestConstructor()
        {
            //arrange
            var currentProduct = new Product(1, "Saw", "sharp blade");
            var expected = "Hello: Saw (1) sharp blade";
            //"Hello: " + ProductName + " (" + ProductID + ") " + Description;

            //act
            var actual = currentProduct.SayHello();
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        [IgnoreAttribute]
        public void SayHelloTest_ObjInitilizer()
        {
            //arrange
            var currentProduct = new Product
            {
                ProductName = "Saw",
                ProductID = 1,
                Description = "sharp blade"
            };
            var expected = "Hello: Saw (1) sharp blade";
            //"Hello: " + ProductName + " (" + ProductID + ") " + Description;

            //act
            var actual = currentProduct.SayHello();
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void StringFunctTest()
        {
            var product = new Product();
            var expected =@"Insert \n to define a new line";

            var actual = product.StringFunct();
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);

        }
    }

}