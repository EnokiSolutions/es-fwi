using System.Threading;
using System.Threading.Tasks;

namespace Es.FwI
{
    public interface IRun
    {
        Task Run(CancellationToken token);
    }
}