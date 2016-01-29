using ZendeskApi.Contracts.Models;

namespace ZendeskApi.Client.Resources
{
    public interface IVoiceResource
    {
        void Display<T>(DisplayRequest<T> request) where T : IZendeskEntity;
    }
}