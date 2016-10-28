using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2.tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            addGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);


        }

        private void addGrades(float[] grades)
        {
            grades[4] = 89.1f;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015,1,1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);

        }
        [TestMethod]
        public void ValuetypesPassByValue()
        {
            int x = 46;
            Assert.AreEqual(46,x);
        }
        private void IncrementNumber(int number) {

            number += 1;
        }

        [TestMethod]
        public void ReferencetypesByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;
            GivebookAName(book2);
            Assert.AreEqual("A gradebook", book1.Name);
        }

        private void GivebookAName(Gradebook book) {
            book.Name = "A gradebook";
        }



        [TestMethod]
        public void StringComparasions()
        {
            String nam1 = "scott";
            String nam2 = "scott";

            bool result = String.Equals(nam1, nam2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            //x1 = 4;
            Assert.AreEqual(x1, x2);

        }


           [TestMethod]
           public void  VariablesHoldReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;
            //g1 = new Gradebook();
            g1.Name = "Scott' s grade book";
            Assert.AreEqual(g1.Name, g2.Name);

        }  
    }
}
    

