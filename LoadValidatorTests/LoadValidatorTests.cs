using System.Collections.Generic;
using Xunit;

namespace LoadValidator.Tests
{

    public class LoadValidatorTests
    {
        [Fact]
        public void IsChangeNeeded_ShouldBeSuccess()
        {
            Assert.True(LoadValidator.IsChangeNeeded(new List<int> { 5, 4, 2, 3, 1 }));
            Assert.True(LoadValidator.IsChangeNeeded(new List<int> { 5, 4, 9, 2, 1, 6 }));

            Assert.False(LoadValidator.IsChangeNeeded(new List<int> { 2, 1 }));
        }

        [Fact]
        public void ChangePosition_ShouldBeSuccess()
        {
            Assert.Equal(new List<int> { 5, 4, 3, 2, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 2, 3, 1 }));
            Assert.Equal(new List<int> { 5, 4, 9, 2, 6, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 9, 2, 1, 6 }));
            Assert.Equal(new List<int> { 5, 9, 4, 6, 2, 1 }, LoadValidator.ChangePosition(new List<int> { 5, 4, 9, 6, 2, 1 }));
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