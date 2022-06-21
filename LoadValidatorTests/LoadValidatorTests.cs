using System.Collections.Generic;
using Xunit;

namespace LoadValidator.Tests
{
    public class LoadValidatorTests
    {
        [Fact]
        public void PositionsToBeChanged_ShouldBeSuccess()
        {
            Assert.Equal(3, LoadValidator.PositionsToBeChanged(new List<int> { 5, 4, 2, 3, 1 }).Position1);
            Assert.Equal(2, LoadValidator.PositionsToBeChanged(new List<int> { 5, 4, 2, 3, 1 }).Position2);

            Assert.Equal(5, LoadValidator.PositionsToBeChanged(new List<int> { 5, 4, 9, 2, 1, 6 }).Position1);
            Assert.Equal(4, LoadValidator.PositionsToBeChanged(new List<int> { 5, 4, 9, 2, 1, 6 }).Position2);

            Assert.Null(LoadValidator.PositionsToBeChanged(new List<int> { 2, 1 }));
        }

        [Fact]
        public void ChangePosition_ShouldBeSuccess()
        {
            Assert.Equal(new List<int> { 5, 4, 3, 2, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 2, 3, 1 }, 2, 3));
            Assert.Equal(new List<int> { 5, 4, 9, 2, 6, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 9, 2, 1, 6 }, 4, 5));
            Assert.Equal(new List<int> { 5, 9, 4, 6, 2, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 9, 6, 2, 1 }, 1, 2));
        }

        [Fact]
        public void StepsNeeded_ShouldBeSuccess()
        {
            Assert.Equal(1, LoadValidator.StepsNeeded(new List<int> { 5, 4, 2, 3, 1 }));
            Assert.Equal(6, LoadValidator.StepsNeeded(new List<int> { 5, 4, 9, 2, 1, 6 }));
            Assert.Equal(0, LoadValidator.StepsNeeded(new List<int> { 2, 1 }));
        }
    }
}