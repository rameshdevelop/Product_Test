using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Group6_Assignment_2;
using System.Threading.Tasks;

namespace ProductTests
{
    [TestFixture]

    public class TestProduct
    {
        [Test]
        public void ProductConstructor_ValidInputRedmi14_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Redmi 14";
            int price = 650;
            int stock = 7;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void ProductConstructor_ValidInputRedmi14Pro_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 60000;
            string productName = "Redmi 14 Pro";
            int price = 650;
            int stock = 7;

            int expected = 60000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputGalaxyS21_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 45000;
            string productName = "Galaxy S21";
            int price = 650;
            int stock = 7;

            int expected = 45000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputGalaxyA52_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Galaxy A52";
            int price = 650;
            int stock = 7;

            string expected = "Galaxy A52";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputOnePlus9_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "OnePlus 9";
            int price = 650;
            int stock = 7;

            string expected = "OnePlus 9";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMi11_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Mi 11";
            int price = 650;
            int stock = 7;

            string expected = "Mi 11";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputNokia5_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Nokia 5";
            int price = 250;
            int stock = 6;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMotoG100_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Moto G100";
            int price = 250;
            int stock = 600000;

            int expected = 600000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputOnePlus8T_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "OnePlus 8T";
            int price = 250;
            int stock = 450000;

            int expected = 450000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputVelvet_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Velvet";
            int price = 6;
            int stock = 6;

            double expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputNova8_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Nova 8";
            int price = 6000;
            int stock = 6;

            double expected = 6000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputPocoX3_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Poco X3";
            int price = 4500;
            int stock = 6;

            int expected = 4500;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMotoEdge20_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Moto Edge 20";
            int price = 2700;
            int stock = 100;
            int increaseStock = 6;

            int expected = 106;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputXperiaL4_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Xperia L4";
            int price = 2700;
            int stock = 100;
            int increaseStock = 600000;

            int expected = 600100;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputIphone15_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Iphone 15";
            int price = 2700;
            int stock = 100;
            int increaseStock = 255500;

            int expected = 255600;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputPixel3_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Pixel 3";
            int price = 2700;
            int stock = 100;
            int DecreaseStock = 10;

            int expected = 90;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMateX2_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Mate X2";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 250;

            int expected = 5750;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputWing5G_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Wing 5G";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 1000;

            int expected = 5000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}

