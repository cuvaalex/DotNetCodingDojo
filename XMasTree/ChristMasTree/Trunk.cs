using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristMasTree
{
    public class Trunk
    {
        private int lastBranchSize;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="lastBranchSize">Size of the last branch</param>
        public Trunk(int lastBranchSize)
        {
            this.lastBranchSize = lastBranchSize;

            this.TrunkBaseLineSize = CalculTrunkBaseLine(lastBranchSize);
        }
        /// <summary>
        /// Trunk base line size
        /// </summary>
        public virtual int TrunkBaseLineSize { get; private set; }

        /// <summary>
        /// Return a String representation of the trunk
        /// </summary>
        /// <returns>a trunk</returns>
        public override string ToString()
        {
            StringBuilder trunk = new StringBuilder(TrunkBaseLineSize);
            trunk.Append("|");
            for (int trunkBase = 1; trunkBase <= TrunkBaseLineSize; trunkBase++)
            {
                trunk.Append("_");
            }
            trunk.Append("|");
            return trunk.ToString();
        }

        private static int CalculTrunkBaseLine(int lastBranchSize)
        {
            return lastBranchSize / 3;
        }

    }
}
