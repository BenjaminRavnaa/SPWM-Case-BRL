namespace spwmTWR;
using System.Collections.Generic;

    public static class TWR
    {
        public static double CalculateTWR(List<double> dailyReturns){
            double finalResult = 1;
            foreach (var dailyReturn in dailyReturns)
            {
                finalResult = finalResult * (1 + dailyReturn);
            }

            return finalResult-1;
        }
    }
