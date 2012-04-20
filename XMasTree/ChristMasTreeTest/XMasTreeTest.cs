using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChristMasTree;

namespace XMasTreeTest
{
    [TestFixture]
    public class XMasTreeTest
    {
        [Test]
        public void ShouldNotThrowAnExceptionWhenSizeEquals3()
        {
            new XMasTree(3);
        }

        [Test]
        public void ShouldNotThrowAnExceptionWhenSizeMoreThan3()
        {
            new XMasTree(5);
        }
        
        [Test]
        [ExpectedException(ExpectedException=typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenSizeUnder3() 
        {
           XMasTree tree = new XMasTree(2);    
        }
        
    }
}
