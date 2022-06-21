using System.Collections.Generic;
using Xunit;

namespace LoadValidator.Tests
{
    public class LoadValidatorTests
    {
        [Fact]
        public void StepsNeeded_ShouldBeSuccess()
        {
            Assert.Equal(7, LoadValidator.StepsNeeded(new List<int> { 5, 4, 2, 3, 1 }));
            Assert.Equal(6, LoadValidator.StepsNeeded(new List<int> { 5, 4, 9, 2, 1, 6 }));
            Assert.Equal(1, LoadValidator.StepsNeeded(new List<int> { 2, 1 }));
        }
    }
}