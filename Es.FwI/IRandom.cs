using System;

// ReSharper disable UnusedMember.Global

namespace Es.FwI
{
    public interface IRandom
    {
        /// <summary>
        ///     Fill an array segment of bytes with random bytes
        /// </summary>
        /// <param name="toFill">array segment to populate with random bytes</param>
        void Fill(ArraySegment<byte> toFill);

        /// <summary>
        ///     Return a random ulong
        /// </summary>
        /// <returns>Returns a random ulong</returns>
        ulong Ulong();
    }
}