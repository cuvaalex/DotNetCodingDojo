using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristMasTree
{
    public class Branch
    {

        public Branch(int branchPosition)
        {
            this.BranchPosition = branchPosition;

            this.BranchSize = CalculateBranchSize();            
        }

        public virtual int BranchSize { get; set; }
        public int BranchPosition { get; set; }

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

        public override string ToString()
        {
            StringBuilder branch = new StringBuilder(BranchSize);
            for (int leaf = 1; leaf <= BranchSize; leaf++)
            {
                branch.Append("* ");
            }
            return branch.ToString().TrimEnd();
        }
    }
}
