using System.Collections.Generic;

namespace LoadValidator
{
    public static class LoadValidator
    {
        public static bool IsChangeNeeded(List<int> input)
        {
            for (int i = input.Count - 1; i >= 0; i--)
                if (i > 0 && input[i] > input[i - 1]) return true;

            return false;
        }

        public static List<int> ChangePosition(List<int> input)
        {
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (i > 0 && input[i] > input[i - 1])
                {
                    var temp = input[i];
                    input[i] = input[i - 1];
                    input[i - 1] = temp;

                    return input;
                }
            }

            return input;
        }

        private static int StepsNeeded(List<int> input, int steps = 0)
        {
            if (IsChangeNeeded(input))
            {
                input = ChangePosition(input);
                steps++;
                return StepsNeeded(input, steps);
            }
            
            return steps;
        }

        public static int StepsNeeded(List<int> input) =>
            StepsNeeded(input, 0);
    }
}
