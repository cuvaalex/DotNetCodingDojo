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

        [Test]
        public void ShouldFound4TheBigestBranchInAListOf5Branches()
        {
            int expected = (4 * 2 - 1);
            IList<Branch> branches = CreateListOfBranches(5);

            int maxFound = Branch.MaxBranchSize(branches);

            Assert.That(maxFound, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldFound6TheBigestBranchInAListOf8Branches()
        {
            int expected = (6 * 2 - 1);
            IList<Branch> branches = CreateListOfBranches(8);

            int maxFound = Branch.MaxBranchSize(branches);

            Assert.That(maxFound, Is.EqualTo(expected));
        }

        private static IList<Branch> CreateListOfBranches(int numberOfBranches)
        {
            IList<Branch> branches = new List<Branch>(numberOfBranches);
            for (int i = 1; i <= numberOfBranches; i++)
            {
                branches.Add(new Branch(i));
            }
            return branches;
        }
    }
}
