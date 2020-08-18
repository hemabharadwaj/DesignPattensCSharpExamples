﻿using Company.Example.Interface;

namespace Company.Example
{
    public class ClaimCalculatorFactory
    {
        public static IClaimCalculator create()
        {
            RuleList ruleList = new RuleList();
            FixedConditions fixedConditions = new FixedConditions();
            return new StandardClaimCalculator(ruleList, fixedConditions);
        }
    }
}
