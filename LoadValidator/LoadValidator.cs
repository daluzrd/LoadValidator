using System.Collections.Generic;

namespace LoadValidator
{
    public class ChangeResult
    {
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public ChangeResult(int position1 = 0, int position2 = 0)
        {
            Position1 = position1;
            Position2 = position2;
        }
    }

    public static class LoadValidator
    {

        public static ChangeResult PositionsToBeChanged(List<int> stack)
        {
            for (int i = stack.Count - 1; i >= 0; i--)
                if (i > 0 && stack[i] > stack[i - 1]) return new ChangeResult(i, i - 1);

            return null;
        }

        public static List<int> ChangePosition(List<int> stack, int position1, int position2)
        {
            (stack[position1], stack[position2]) = (stack[position2], stack[position1]);
            return stack;
        }

        private static int StepsNeeded(List<int> stack, int steps)
        {
            var changes = PositionsToBeChanged(stack);
            if (changes != null)
            {
                stack = ChangePosition(stack, changes.Position1, changes.Position2);
                steps++;
                return StepsNeeded(stack, steps);
            }

            return steps;
        }

        public static int StepsNeeded(List<int> stack) =>
            StepsNeeded(stack, 0);
    }
}