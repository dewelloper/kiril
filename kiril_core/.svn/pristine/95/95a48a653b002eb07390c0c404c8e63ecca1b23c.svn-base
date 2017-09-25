using Markum.Cloud.Libraries.LibraryObjects;
using Markum.Cloud.Libraries.Server;
using Markum.Cloud.Services.Interfaces;
using System;

namespace Markum.Cloud.Services.Services
{
    public class SolusVmService : SolusBase, IServerService
    {
        public SolusResponseBase ChangeServerMemorySize(ServerChangeMemoryModel serverChangeMemoryModel)
        {
            return CreateRequest<SolusResponseBase>(serverChangeMemoryModel, "");
        }

        public SolusCreateResponse CreateServer(Libraries.Server.ServerCreateModel serverCreateModel)
        {
            return CreateRequest<SolusCreateResponse>(serverCreateModel, "vserver-create");
        }

        public SolusResponseBase RemoveServer(ServerRemoveModel serverRemoveModel)
        {
            return CreateRequest<SolusResponseBase>(serverRemoveModel, "vserver-terminate");
        }

    }
}
