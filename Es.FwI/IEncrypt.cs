using System;

namespace Es.FwI
{
    public interface IEncrypt
    {
        IEncryptInfo Analyze(ArraySegment<byte> unencryptedInput);
        int Encrypt(ArraySegment<byte> unencryptedInput, ArraySegment<byte> encryptedOutput, IEncryptInfo info);
    }
}