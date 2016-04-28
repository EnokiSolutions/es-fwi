using System;

namespace Es.FwI
{
    public interface IDecrypt
    {
        IDecryptInfo Analyze(ArraySegment<byte> encryptedInput);
        /// <summary>
        /// Decrypts input into output
        /// </summary>
        /// <param name="encryptedInput"></param>
        /// <param name="decryptedOutput"></param>
        /// <param name="info"></param>
        /// <returns>Actual size of output</returns>
        int Decrypt(ArraySegment<byte> encryptedInput, ArraySegment<byte> decryptedOutput, IDecryptInfo info);
    }
}