using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global

namespace Es.FwI
{
    /// <summary>
    ///     Transforms an array segment of bytes into another array segement of bytes.
    /// </summary>
    public interface ICompress
    {
        /// <summary>
        ///     Determines the maximum number of bytes that could be output for a given count of number of uncompressed input bytes
        /// </summary>
        /// <param name="uncompressedInput">uncompressed input to be compressed</param>
        /// <returns></returns>
        ICompressInfo Analyze(ArraySegment<byte> uncompressedInput);

        /// <summary>
        ///     Transforms the uncompressedInput into the compressedOutput. Use MaxOutputCount to determine how large the
        ///     compressedOutput needs to be be in the
        ///     worst case and ensure you've allocated it.
        /// </summary>
        /// <param name="uncompressedInput">uncompressedInput byte array segement</param>
        /// <param name="compressedOutput">compressedOutput byte array segement</param>
        /// <param name="info"></param>
        /// <returns></returns>
        int Compress(ArraySegment<byte> uncompressedInput, ArraySegment<byte> compressedOutput, ICompressInfo info);
    }
}