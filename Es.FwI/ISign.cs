using System;

namespace Es.FwI
{
    public interface ISign
    {
        int SignatureBytesCount { get; }
        byte[] Sign(ArraySegment<byte> payload);
    }
}