using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class ObamaCare : HealthPlan
    {
        public override string PlanType { get { return "ObamaCare"; } }
        public override int AnnualCharge { get { return 9000; } }
        public override int DeductionAmount { get { return 2000; } }

    }
}
