using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristMasTree
{
    public class XMasTree
    {
        private String treePatern;
        private int treeSize=3;        

        /// <summary>
        /// Tree size Property
        /// If the size of the tree is under 3, it will throw an ArgumentOutOfRangeException
        /// </summary>
        /// <seealso cref="System.ArgumentOutOfRangeException"/>
        public int TreeSize
        {
            get { return treeSize; }
            set {
                if (value < 3)
                {
                    throw new ArgumentOutOfRangeException("The tree should have a size at least of 3");
                }
                this.treeSize = value;
            }
        }        

        /// <summary>
        /// Default Constructor, if the treeSize is under 3, it will throw
        /// an ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="treeSize"></param>
        /// <see cref="System.ArgumentOutOfRangeException"/>
        public XMasTree(int treeSize)
        {
            this.TreeSize = treeSize;
        }

        /// <summary>
        /// Build the tree with the TreeSize
        /// </summary>
        public void Draw()
        {
            IList<Branch> branches;
            Trunk trunk;
            BuildTreeObjects(out branches, out trunk);

            int maxBranchSize = Branch.MaxBranchSize(branches);
            int padding = (maxBranchSize+1) / 2; 

            StringBuilder tree = new StringBuilder();
            foreach (var branch in branches)
            {
                tree.AppendLine(branch.ToString(padding));
            }
            tree.AppendLine(trunk.ToString(padding));

            treePatern = tree.ToString().TrimEnd();
        }

        private void BuildTreeObjects(out IList<Branch> branches, out Trunk trunk)
        {
            branches = GetBranches(treeSize);
            trunk = GetTrunk(branches[TreeSize - 1].BranchSize);
        }

        /// <summary>
        /// Return a String representation of the XMasTree
        /// </summary>
        /// <returns>Return the XMasTree</returns>
        public override string ToString()
        {
            return treePatern;
        }

        private Trunk GetTrunk(int baseLineSize)
        {
            return new Trunk(baseLineSize);
        }

        private IList<Branch> GetBranches(int treeSize)
        {
            IList<Branch> branches = new List<Branch>();
            for (int nbBranche = 1; nbBranche <= treeSize; nbBranche++)
            {
                branches.Add(new Branch(nbBranche));
            }
            return branches;
        }
    }
}
