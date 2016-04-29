using System;

namespace Es.FwI
{
    public interface IUtcDateTimeProvider
    {
        DateTime Epoch { get; }
        DateTime UtcNow { get; }
    }
}