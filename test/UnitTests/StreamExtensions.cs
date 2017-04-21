using System;
using System.Linq;
using Nito.ArraySegments;
using Xunit;

namespace UnitTests
{
    public class StreamExtensions
    {
        [Fact]
        public void CreateStream_CreatesStreamCoveringOnlySegment()
        {
            var bytes = new byte[] { 1, 2, 3, 4, 5 }.AsArraySegment()
                .Slice(1, 3);

            byte[] result;
            using (var stream = bytes.CreateStream())
                result = stream.ToArray();

            Assert.Equal(new byte[] { 2, 3, 4 }, result);
        }
    }
}
