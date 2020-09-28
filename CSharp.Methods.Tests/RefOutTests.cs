using CSharp.Tests.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Methods.Tests
{
    public class RefOutTests
    {
        private dynamic _object;
        private TypeAssert _test;
        [SetUp]
        public void Setup()
        {
            _object = new RefOut();
            _test = new TypeAssert<RefOut>();
        }

        [Test]
        [Category("Easy")]
        public void Swap()
        {
            _test.Method(
                "Swap",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a") { Ref = true },
                new Param<int>("b") { Ref = true }
                );
            int a = 100;
            int b = 200;
            _object.Swap(ref a, ref b);

            Assert.AreEqual(200, a, "the second argument should be swapped to the first argument");
            Assert.AreEqual(100, b, "the first argument should be swapped to the second argument");
        }

        [Test]
        [Category("Medium")]
        public void Rotate()
        {
            _test.Method(
                "Rotate",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a") { Ref = true },
                new Param<int>("b") { Ref = true },
                new Param<int>("c") { Ref = true },
                new Param<bool>("leftToRight") { Default = false }
                );
            int a = 100;
            int b = 200;
            int c = 300;
            _object.Rotate(ref a, ref b, ref c);
            Assert.AreEqual(200, a);
            Assert.AreEqual(300, b);
            Assert.AreEqual(100, c);

            a = 100;
            b = 200;
            c = 300;
            _object.Rotate(ref a, ref b, ref c, false);
            Assert.AreEqual(200, a);
            Assert.AreEqual(300, b);
            Assert.AreEqual(100, c);

            a = 100;
            b = 200;
            c = 300;
            _object.Rotate(ref a, ref b, ref c, true);
            Assert.AreEqual(300, a);
            Assert.AreEqual(100, b);
            Assert.AreEqual(200, c);
        }

        [Test]
        [Category("Easy")]
        public void Calculate()
        {
            _test.Method<int>(
                "Calculate",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b"),
                new Param<int>("sub") { Out = true },
                new Param<int>("mul") { Out = true },
                new Param<int>("div") { Out = true },
                new Param<int>("mod") { Out = true }
             );

            int a = 123;
            int b = 17;
            int add, sub, mul, div, mod;
            add = _object.Calculate(a, b, out sub, out mul, out div, out mod);

            Assert.AreEqual(123 + 17, add); // 140
            Assert.AreEqual(123 - 17, sub); // 106
            Assert.AreEqual(123 * 17, mul); // 2091
            Assert.AreEqual(123 / 17, div); // 7
            Assert.AreEqual(123 % 17, mod); // 4
        }
    }
}
