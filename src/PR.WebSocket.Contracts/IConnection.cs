using System.Net;
using System.Threading.Tasks;

namespace PR.WebSocket.Contracts
{
    public interface IConnection
    {
        IPEndPoint IP { get; }

        Task SendAsync(string msg);

        void Send(string msg);
    }
}