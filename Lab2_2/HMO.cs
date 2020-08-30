using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class HMO : HealthPlan
    {
        public override string planType { get { return "HMO"; } }
        public override int annualCharge { get { return 10000; } }
        public override int deductionAmount { get { return 3000; } }

    }
}
