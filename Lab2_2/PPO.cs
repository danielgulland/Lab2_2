using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class PPO : HealthPlan
    {
        public override string PlanType { get { return "PPO"; } }
        public override int AnnualCharge { get { return 8000; } }
        public override int DeductionAmount { get { return 1000; } }

    }
}
