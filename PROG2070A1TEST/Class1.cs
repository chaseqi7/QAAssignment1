using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070A1ZQ;

namespace PROG2070A1TEST
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestAddToRadius_RadiusIs3Add5_Expect8()
        {
            Circle cTest = new Circle();
            cTest.Radius = 3;
            int add = 5;

            cTest.AddToRadius(add);
            Assert.AreEqual(8, cTest.Radius);
        }
        [Test]
        public void TestAddToRadius_RadiusIs5AddMinus3_Expect2()
        {
            Circle cTest = new Circle();
            cTest.Radius = 5;
            int add = -3;

            cTest.AddToRadius(add);
            Assert.AreEqual(2, cTest.Radius);
        }
        [Test]
        public void TestSubtractFromRadius_RadiusIs5Minus3_Expect2()
        {
            Circle cTest = new Circle();
            cTest.Radius = 5;
            int minus = 3;

            cTest.SubtractFromRadius(minus);
            Assert.AreEqual(2, cTest.Radius);
        }
        [Test]
        public void TestSubtractFromRadius_RadiusIs5Minusminus3_Expect8()
        {
            Circle cTest = new Circle();
            cTest.Radius = 5;
            int minus = -3;

            cTest.SubtractFromRadius(minus);
            Assert.AreEqual(8, cTest.Radius);
        }
        [Test]
        public void TestGetCircumference_RadiusIs5_Expect31_42()
        {
            Circle cTest = new Circle();
            cTest.Radius = 5;
            
            Assert.AreEqual(31.42, cTest.GetCircumference());
        }
        [Test]
        public void TestGetCircumference_RadiusIs3point5_Expect21_99()
        {
            Circle cTest = new Circle();
            cTest.Radius = 3.5;

            Assert.AreEqual(21.99, cTest.GetCircumference());
        }
        [Test]
        public void TestGetArea_RadiusIs6_Expect113_10()
        {
            Circle cTest = new Circle();
            cTest.Radius = 6;

            Assert.AreEqual(113.10, cTest.GetArea());
        }
        [Test]
        public void TestGetArea_RadiusIs4point6_Expect66_48()
        {
            Circle cTest = new Circle();
            cTest.Radius = 4.6;

            Assert.AreEqual(66.48, cTest.GetArea());
        }
        [Test]
        public void TestNonDefaultConstructor_Expect10()
        {
            Circle cTest = new Circle(10);

            Assert.AreEqual(10, cTest.Radius);
        }
    }

}
