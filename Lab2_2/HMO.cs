using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class HMO : HealthPlan
    {
        public override string PlanType { get { return "HMO"; } }
        public override int AnnualCharge { get { return 10000; } }
        public override int DeductionAmount { get { return 3000; } }

    }
}
