using Microsoft.VisualStudio.TestTools.UnitTesting;
using NZ_Tax_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator.Tests
{
    [TestClass()]
    public class Tax_GeneratorTests
    {
        [TestMethod()]
        public void CalculateTest1()
        {
            //Arrange
            var tax_generator = new Tax_Generator();
            double income = 30000;

            //Act
            tax_generator.Calculate(income);

            //Assert
            Assert.AreEqual(4270, tax_generator.Calculate(income));
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            //Arrange
            var tax_generator = new Tax_Generator();
            double income = 90000;

            //Act
            tax_generator.Calculate(income);

            //Assert
            Assert.AreEqual(20620, tax_generator.Calculate(income));
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            //Arrange
            var tax_generator = new Tax_Generator();
            double income = 5000.25;

            //Act
            tax_generator.Calculate(income);

            //Assert
            Assert.AreEqual(525, tax_generator.Calculate(income));
        }
    }
}