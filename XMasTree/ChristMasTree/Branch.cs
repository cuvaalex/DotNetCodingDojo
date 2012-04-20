using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristMasTree
{
    public class Branch
    {
        private int level;

        public Branch(int level)
        {
            this.level = level;

            this.Size = GetBranchSize(level);            
        }

        private int GetBranchSize(int level)
        {
            if (level % 5 == 0)
            {
                return level - 1 - (level / 5);
            }
            else
            {
                return level - (1 * (level / 5) + (level / 5));
            }
        }

        public int Size { get; set; }

        public override string ToString()
        {
            StringBuilder branch = new StringBuilder(Size);
            for (int leaf = 1; leaf <= Size; leaf++)
            {
                branch.Append("* ");
            }
            return branch.ToString().TrimEnd();
        }
    }
}
