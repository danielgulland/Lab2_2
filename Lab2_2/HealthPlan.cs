using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    abstract class HealthPlan
    {
        public abstract string planType { get; }
        public abstract int annualCharge { get;}
        public abstract int deductionAmount { get;}

        public override String ToString()
        {
            return "\nPlan Type - " + this.planType + "\nAnnual Charge - " + this.annualCharge
                + "\nDeduction Amount - " + this.deductionAmount;
        }

    }
}
