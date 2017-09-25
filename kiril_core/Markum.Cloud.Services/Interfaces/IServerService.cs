
using Markum.Cloud.Libraries.Server;

namespace Markum.Cloud.Services.Interfaces
{
    public interface IServerService
    {
        SolusCreateResponse CreateServer(Libraries.Server.ServerCreateModel serverCreateModel);
        SolusResponseBase RemoveServer(ServerRemoveModel serverRemoveModel);

        SolusResponseBase ChangeServerMemorySize(ServerChangeMemoryModel serverChangeMemoryModel);

    }
}
