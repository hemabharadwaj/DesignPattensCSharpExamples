using Company.Example.Interface;
using System;

namespace Company.Example
{
    public class ClaimCreator
    {
        public double create(String code, double amount)
        {
            IClaimCalculator claimCalculator = ClaimCalculatorFactory.create();
            return claimCalculator.calculateClaimAmount(code, amount);
        }
    }
}
