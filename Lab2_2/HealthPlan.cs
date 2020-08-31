using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    abstract class HealthPlan
    {
        public abstract string PlanType { get; }
        public abstract int AnnualCharge { get;}
        public abstract int DeductionAmount { get;}

        public override String ToString()
        {
            return "\nPlan Type - " + this.PlanType + "\nAnnual Charge - " + this.AnnualCharge
                + "\nDeduction Amount - " + this.DeductionAmount;
        }

    }
}
