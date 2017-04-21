using System;
using System.IO;

namespace Nito.ArraySegments
{
    /// <summary>
    /// Provides stream-related extension methods for <see cref="ArraySegment{T}"/> and <see cref="ArraySegmentReader{T}"/>.
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Creates a <see cref="MemoryStream"/> over this array segment. Multiple streams may be created for the same array and array segment, but if one of them writes then any buffering will cause inconsistent views.
        /// </summary>
        /// <param name="segment">The array segment.</param>
        /// <param name="writable">A value indicating whether the stream is writable. Defautls to <c>true</c>.</param>
        /// <returns>A new <see cref="MemoryStream"/>.</returns>
        public static MemoryStream CreateStream(this ArraySegment<byte> segment, bool writable = true) =>
            new MemoryStream(segment.Array, segment.Offset, segment.Count, writable);

        /// <summary>
        /// Creates a <see cref="BinaryReader"/> over this array segment.
        /// </summary>
        /// <param name="segment">The array segment.</param>
        /// <returns>A new <see cref="BinaryReader"/>.</returns>
        public static BinaryReader CreateBinaryReader(this ArraySegment<byte> segment) => new BinaryReader(segment.CreateStream(false));

        /// <summary>
        /// Creates a <see cref="BinaryWriter"/> over this array segment.
        /// </summary>
        /// <param name="segment">The array segment.</param>
        /// <returns>A new <see cref="BinaryWriter"/>.</returns>
        public static BinaryWriter CreateBinaryWriter(this ArraySegment<byte> segment) => new BinaryWriter(segment.CreateStream(true));
    }
}