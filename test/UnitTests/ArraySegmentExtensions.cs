using System;
using System.Linq;
using Nito.ArraySegments;
using Xunit;

namespace UnitTests
{
    public class ArraySegmentExtensions
    {
        [Fact]
        public void Take_TakesElements()
        {
            var segment = new[] { 1, 2, 3 }.AsArraySegment();
            ArraySegment<int> result = segment.Take(1);
            Assert.Same(segment.Array, result.Array);
            Assert.Equal(segment.Offset, result.Offset);
            Assert.Equal(result.Count, 1);
            Assert.True(result.SequenceEqual(new[] { 1 }));
        }
    }
}
