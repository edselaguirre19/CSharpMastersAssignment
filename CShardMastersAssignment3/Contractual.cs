using System;
using System.Collections.Generic;
using System.Text;

namespace CShardMastersAssignment3
{
    public abstract class Contractual
    {
        
        public virtual double Payout(bool isContractual)
        {
            //return base computation.
            return 0;
        }

        public virtual double Payout(double basepay)
        {
            //return base computation.
            return basepay;


        }
        public virtual double Payout()
        {
            //return base computation.
            return 0;
        }

    }
}
