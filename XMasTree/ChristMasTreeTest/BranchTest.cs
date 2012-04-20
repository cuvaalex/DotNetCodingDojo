using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChristMasTree;

namespace XMasTreeTest
{
    [TestFixture]
    public class BranchTest
    {

        [Test]
        public void ShouldNotThrowAnExceptionIfTheBranchPositionIsGreatherThan0()
        {
            new Branch(1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnArgumentOutOfRangeExceptionIfTheBranchPositionIsLessThan1()
        {
            new Branch(-1);
        }
        
        [TestCase(4, 6, "* * * *")]
        [TestCase(3, 5, "* * *")]
        [TestCase(4, 4, "* * * *")]
        [TestCase(1, 1, "*")]
        public void ShouldHaveSizeWhenLevel(int expected, int level, String expectedPatern)
        {

            Branch branch = new Branch(level);
            int branchSize = branch.BranchSize;

            Assert.That(branchSize, Is.EqualTo(expected));

            String branchDraw = branch.ToString();
            Assert.That(branchDraw, Is.EqualTo(expectedPatern));
        }
    
    }
}
