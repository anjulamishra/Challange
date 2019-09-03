using System;
using System.IO;
using System.Text;
using Challange;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {


        [TestMethod]
        public void RunMain()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("w"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    var expected = new StringBuilder("Please enter a Letter between A and Z\r\n\r\n                      a\r\n                     b b\r\n" +
                      "                    c   c\r\n                   d     d\r\n                  e       e\r\n                 f         f\r\n" +
                      "                g           g\r\n               h             h\r\n              i               i\r\n             j" +
                      "                 j\r\n            k                   k\r\n           l                     l\r\n          m" +
                      "                       m\r\n         n                         n\r\n        o                           o\r\n       p" +
                      "                             p\r\n      q                               q\r\n     r                                 r\r\n    s" +
                      "                                   s\r\n   t                                     t\r\n  u                                       u\r\n v" +
                      "                                         v\r\nw                                           w\r\n v" +
                      "                                         v\r\n  u                                       u\r\n   t " +
                      "                                    t\r\n    s                                   s\r\n     r" +
                      "                                 r\r\n      q                               q\r\n       p" +
                      "                             p\r\n        o                           o\r\n         n" +
                      "                         n\r\n          m                       m\r\n           l" +
                      "                     l\r\n            k                   k\r\n             j                 j\r\n" +
                      "              i               i\r\n               h             h\r\n                g           g\r\n" +
                      "                 f         f\r\n                  e       e\r\n                   d     d\r\n" +
                      "                    c   c\r\n                     b b\r\n                      a");

                    Assert.AreEqual<string>(expected.ToString(), sw.ToString().Trim());
                }
            }
        }

        [TestMethod]

        public void Validate()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("1"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    string expected = "Invalid entry, please enter a Letter between A and Z";
                    string[] consoleOutputArray = sw.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    var actual = consoleOutputArray[1].ToString().Replace("\n", "").Trim();
                    Assert.AreEqual<string>(expected.ToString(), actual);
                }
            }
        }

    }
}
