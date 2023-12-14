namespace Blog.Server.Authorization
{
    public interface IOwnerObject
    {
        string? ObjectOwnerId { get; }
    }
}
