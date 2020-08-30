using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class PPO : HealthPlan
    {
        public override string planType { get { return "PPO"; } }
        public override int annualCharge { get { return 8000; } }
        public override int deductionAmount { get { return 1000; } }

    }
}
