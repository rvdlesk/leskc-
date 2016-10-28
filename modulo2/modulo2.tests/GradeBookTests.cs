using modulo2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2.tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            Gradebook book = new Gradebook();
            book.addGrade(10);
            book.addGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);

        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            Gradebook book = new Gradebook();
            book.addGrade(10);
            book.addGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);

        }
        [TestMethod]
        public void ComputeAverageGrade()
        {
            Gradebook book = new Gradebook();
            book.addGrade(91);
            book.addGrade(89.5f);
            book.addGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade,0.01);

        }
    }
}
