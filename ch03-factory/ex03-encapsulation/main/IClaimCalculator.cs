using System;

namespace Company.Example.Interface
{
    public interface IClaimCalculator
    {
        double calculateClaimAmount(String code, double amount);
    }
}
