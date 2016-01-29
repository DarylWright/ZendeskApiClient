using ZendeskApi.Client.Http;
using ZendeskApi.Contracts.Models;

namespace ZendeskApi.Client.Resources
{
    public class VoiceResource : IVoiceResource
    {
        private readonly IRestClient _client;

        private const string VoiceUri = @"/api/v2/channels/voice/";

        public VoiceResource(IRestClient client)
        {
            _client = client;
        }

        public void Display<T>(DisplayRequest<T> request) where T : IZendeskEntity
        {
            var displayType = string.Empty;

            if (request is DisplayTicketRequest)
            {
                displayType = "tickets";
            }
            else if (request is DisplayUserRequest)
            {
                displayType = "users";
            }
            
            var uri = string.Format("{0}agents/{1}/{2}/{3}/display.json", VoiceUri, request.Agent.Id, displayType, request.Item.Id);
            
            var requestUri = _client.BuildUri(uri);

            _client.Post(requestUri);
        }
    }
}