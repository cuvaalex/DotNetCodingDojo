using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChristMasTree;

namespace ChristMasTreeAcceptanceTest
{
    [TestFixture]
    public class XMasTreeAcceptance
    {
        [TestCase(  "  *\r\n"
            +       " * *\r\n"
            +       "* * *\r\n"
            + " |_|", 3)]
        [TestCase(  "   *\r\n"
            +       "  * *\r\n"
            +       " * * *\r\n"
            +       "* * * *\r\n"
            + "  |_|", 4)]
        [TestCase(  "   *\r\n"
            +       "  * *\r\n"
            +       " * * *\r\n"
            +       "* * * *\r\n"
            +       " * * *\r\n"
            + "  |_|", 5)]
        [TestCase(  "     *\r\n"
            +       "    * *\r\n"
            +       "   * * *\r\n"
            +       "  * * * *\r\n"
            +       "   * * *\r\n"
            +       "  * * * *\r\n"
            +       " * * * * *\r\n"
            +       "* * * * * *\r\n"
            + "    |__|", 8)]
        public void ShouldReturnAXMasTree(String patern, int size)
        {
            XMasTree tree = new XMasTree(size);
            tree.Draw();
            String returnPatern = tree.ToString();

            Assert.That(returnPatern, Is.EqualTo(patern));
        }
    }
}
