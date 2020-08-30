using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Lab2_2
{
    class HealthPlanFactory
    {
        public static HealthPlan selectHealthPlan(String healthPlan)
        {
            switch(healthPlan)
            {
                case "HMO":
                    return new HMO();
                case "PPO":
                    return new PPO();
                case "ObamaCare":
                    return new ObamaCare();
            }
            return null;
        }
    }
}
