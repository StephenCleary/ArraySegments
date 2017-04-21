using System;
using System.IO;

namespace Nito.ArraySegments
{
    /// <summary>
    /// A reader that divides a source <see cref="ArraySegment{T}"/> into multiple <see cref="ArraySegment{T}"/> instances.
    /// </summary>
    /// <typeparam name="T">The type of elements contained in the array.</typeparam>
    public sealed class ArraySegmentReader<T>
    {
        /// <summary>
        /// The source array segment.
        /// </summary>
        private readonly ArraySegment<T> _source;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySegmentReader&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="source">The source array segment.</param>
        public ArraySegmentReader(ArraySegment<T> source)
        {
            _source = source;
            Position = 0;
        }

        /// <summary>
        /// Gets the source array segment.
        /// </summary>
        public ArraySegment<T> Source { get { return _source; } }

        /// <summary>
        /// Gets or sets the position of this reader.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Creates a new array segment which starts at the current position and covers the specified number of elements.
        /// </summary>
        /// <param name="count">The number of elements in the new array segment.</param>
        /// <returns>The new array segment.</returns>
        public ArraySegment<T> Read(int count)
        {
            var ret = _source.Slice(Position, count);
            Position += count;
            return ret;
        }

        /// <summary>
        /// Sets the position of this reader. Returns the new position.
        /// </summary>
        /// <param name="offset">The offset from the origin.</param>
        /// <param name="origin">The origin to use when setting the position.</param>
        /// <returns>The new position.</returns>
        public int Seek(int offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    Position = offset;
                    break;
                case SeekOrigin.Current:
                    Position += offset;
                    break;
                case SeekOrigin.End:
                    Position = Source.Count + offset;
                    break;
            }

            return Position;
        }
    }
}
