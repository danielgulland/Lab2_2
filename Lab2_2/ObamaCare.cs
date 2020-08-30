using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class ObamaCare : HealthPlan
    {
        public override string planType { get { return "ObamaCare"; } }
        public override int annualCharge { get { return 9000; } }
        public override int deductionAmount { get { return 2000; } }

    }
}
