﻿using Company.Example.Interface;
using System;

namespace Company.Example
{
    public class StandardClaimCalculator : IClaimCalculator
    {
        private RuleList ruleList;
        private FixedConditions fixedConditions;

        public StandardClaimCalculator(RuleList ruleList, FixedConditions fixedConditions)
        {
            this.ruleList = ruleList;
            this.fixedConditions = fixedConditions;
        }
        public double calculateClaimAmount(String code, double amount)
        {
            // use ruleList and fixedConditions to
            // calculate claim amount
            return amount;
        }

    }
}
