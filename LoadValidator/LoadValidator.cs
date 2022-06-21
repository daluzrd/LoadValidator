using System.Collections.Generic;
using System.Linq;

namespace LoadValidator
{
    public static class LoadValidator
    {
        public static int StepsNeeded(List<int> input)
        {
            int indexOfMinValue = input.IndexOf(input.Min());
            int stepsBack = indexOfMinValue;

            int indexOfMaxValue = input.IndexOf(input.Max());
            int stepsForward = input.Count - 1 - indexOfMaxValue;

            int steps = stepsBack + stepsForward;
            if (indexOfMinValue > indexOfMaxValue) steps -= 1;

            return steps;
        }
    }
}