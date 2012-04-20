using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChristMasTree;

namespace XMasTreeTest
{
    [TestFixture]
    public class TrunkTest
    {
        [TestCase(1, 3, "|_|")]
        [TestCase(1, 4, "|_|")]
        [TestCase(2, 6, "|__|")]
        public void shouldReturnSizeWhenBaseHasSize(int expectedSize, int branchSize, String patern)
        {
            Trunk trunk = new Trunk(branchSize);
            int trunkSize = trunk.TrunkBaseLineSize;

            Assert.That(trunkSize, Is.EqualTo(expectedSize));

            String resultPatern = trunk.ToString();
            Assert.That(resultPatern, Is.EqualTo(patern));
        }
    }
}
