using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR_TEST_12_04_24_2;
using System.IO;

namespace UnitTest_PR_TEST_12_04_24_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1ch()
        {
            double x = 1;
            double y = 2;
            string Expected = "Точка в 1 четверти";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2ch()
        {
            double x = -1;
            double y = 2;
            string Expected = "Точка в 2 четверти";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod3ch()
        {
            double x = -1;
            double y = -2;
            string Expected = "Точка в 3 четверти";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod4ch()
        {
            double x = 1;
            double y = -2;
            string Expected = "Точка в 4 четверти";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod1_2ch()
        {
            double x = 0;
            double y = 2;
            string Expected = "Точка между 1 и 2 четвертями";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2_3ch()
        {
            double x = -1;
            double y = 0;
            string Expected = "Точка между 2 и 3 четвертями";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod3_4ch()
        {
            double x = 0;
            double y = -2;
            string Expected = "Точка между 3 и 4 четвертями";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod1_4ch()
        {
            double x = 1;
            double y = 0;
            string Expected = "Точка между 1 и 4 четвертями";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }
        [TestMethod]
        public void TestMethod_start_point()
        {
            double x = 0;
            double y = 0;
            string Expected = "Точка в начале координат";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24_2.Program.KoorPl(x, y);

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }


    }
}
