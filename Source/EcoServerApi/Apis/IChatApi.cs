// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using EcoServerApi.Models;
using Refit;
using System.Threading.Tasks;

namespace EcoServerApi.Apis
{
    public interface IChatApi
    {
        [Get("/api/v1/chat")]
        Task ChatGetChat([Query] string authtoken, [Query] string authtokentype, [Query] double? startDay, [Query] double? endDay);

        [Get("/api/v1/chat/tag")]
        Task ChatGetChatByTag([Query] string authtoken, [Query] string authtokentype, [Query] string tag, [Query] double? startDay, [Query] double? endDay);

        [Get("/api/v1/chat/{username}")]
        Task ChatGetChatMessagesSentBy(string username, [Query] string authtoken, [Query] string authtokentype, [Query] double? startDay, [Query] double? endDay);

        [Post("/api/v1/chat/next")]
        Task ChatGetNext([Body] EcoWebCoreDataTransferObjectsV1ChatMessageV1 body, [Query] string authtoken, [Query] string authtokentype, [Query] int? numNextMessages);

        [Post("/api/v1/chat/previous")]
        Task ChatGetPrevious([Body] EcoWebCoreDataTransferObjectsV1ChatMessageV1 body, [Query] string authtoken, [Query] string authtokentype, [Query] int? numPreviousMessages);

        [Get("/api/v1/chat/sendChat")]
        Task ChatSendChat([Query] string authtoken, [Query] string authtokentype, [Query] string username, [Query] string message);
    }
}
