using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenClosed.Test
{
    [TestFixture]
    class OpenClosedOnOrderingTest
    {
        private IEnumerable<IProduct> productList;
        private ProductFilter filterManager;

        [SetUp]
        public void SetUp()
        {
            filterManager = new ProductFilter();

            productList = new List<IProduct>
            {
                new Product("red", "1"),
                new Product("blue", "1"),
                new Product("white", "1"),
                new Product("red", "2"),
                new Product("viola", "3"),
                new Product("black", "3"),
                new Product("red", "4"),
                new Product("brown", "4")
            };
        }

        [TearDown]
        public void TearDown()
        {
            productList = null;
            filterManager = null;
        }

        [Test]
        public void OrderByColor()
        {
            var colorSpecification = new ColorSpecification("red");

            var filteredList = filterManager.Apply(productList, colorSpecification);

            foreach (var product in filteredList)
            {
                    Assert.AreEqual("red", product.Color());
            }

        }

        [Test]
        public void OrderBySize()
        {
            var sizeSpecification = new ColorSpecification("2");

            var filteredList = filterManager.Apply(productList, sizeSpecification);

            foreach (var product in filteredList)
            {
                Assert.AreEqual("2", product.Color());
            }

        }
    }
}
