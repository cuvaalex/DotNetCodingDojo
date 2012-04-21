using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristMasTree
{
    public class Branch
    {
        private static string ERROR_BRANCHPOS = "Branch position should be > 0";
        private int branchPosition;
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="branchPosition"></param>
        public Branch(int branchPosition)
        {            
            this.BranchPosition = branchPosition;

            this.BranchSize = CalculateBranchSize();            
        }
        /// <summary>
        /// Size of the branch or the number of leaf
        /// </summary>
        public virtual int BranchSize { get; set; }
        /// <summary>
        /// Branch position on the tree, where 1 = top of the tree
        /// </summary>
        public int BranchPosition {
            get
            {
                return this.branchPosition;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(ERROR_BRANCHPOS);
                }
                else
                {
                    this.branchPosition = value;
                }
            }
        }

        private int CalculateBranchSize()
        {
            if (BranchPosition % 5 == 0)
            {
                return BranchPosition - 1 - (BranchPosition / 5);
            }
            else
            {
                return BranchPosition - (1 * (BranchPosition / 5) + (BranchPosition / 5));
            }
        }        

        /// <summary>
        /// Draw a Branch String view.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder branch = new StringBuilder(BranchSize);
            for (int leaf = 1; leaf <= BranchSize; leaf++)
            {
                branch.Append("* ");
            }
            return branch.ToString().TrimEnd();
        }

        public static int MaxBranchSize(IList<Branch> branches)
        {
            return branches.Max(b => b.ToString().Length);
        }

        internal string ToString(int padding)
        {
            String branch = this.ToString();
            int totalLength = padding + (branch.Length / 2);
            branch = branch.PadLeft(totalLength);            
            return branch;
        }
    }
}
