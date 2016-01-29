using ZendeskApi.Contracts.Models;
using ZendeskApi.Contracts.Requests;

namespace ZendeskApi.Client.Resources
{
    public abstract class DisplayRequest<T> : IRequest<T> where T : IZendeskEntity
    {
        public User Agent { get; set; }

        public T Item { get; set; }
    }
}