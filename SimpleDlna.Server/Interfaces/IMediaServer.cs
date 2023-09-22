using System;

namespace SimpleDlna.Server
{
  public interface IMediaServer
  {
    IHttpAuthorizationMethod Authorizer { get; }

    string FriendlyName { get; }

    Guid UUID { get; }

    IMediaItem GetItem(string id);
  }
}
