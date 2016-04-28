using System;

// ReSharper disable UnusedMember.Global

namespace Es.FwI
{
    /// <summary>
    ///     Transforms an array segment of bytes into another array segement of bytes.
    /// </summary>
    public interface IDecompress
    {
        /// <summary>
        ///     Determines the DecompressionInfo
        /// </summary>
        /// <param name="compressedInput">bytes that will be decompressed</param>
        /// <returns></returns>
        IDecompressionInfo Analyze(ArraySegment<byte> compressedInput);

        /// <summary>
        ///     Transforms the compressedInput into the decompressedOutput. Use MaxOutputCount to determine how large the decompressedOutput needs to be be in the
        ///     worst case and ensure you've allocated it.
        /// </summary>
        /// <param name="compressedInput">compressedInput byte array segement (compressedInput data)</param>
        /// <param name="decompressedOutput">decompressedOutput byte array segement (where to write the uncompressed data)</param>
        /// <param name="info">decompression info from Analyze</param>
        /// <returns></returns>
        void Decompress(ArraySegment<byte> compressedInput, ArraySegment<byte> decompressedOutput, IDecompressionInfo info);
    }
}