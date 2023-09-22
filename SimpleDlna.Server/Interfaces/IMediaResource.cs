using System.IO;

namespace SimpleDlna.Server
{
  public interface IMediaResource : IMediaItem, IMediaCover
  {
    DlnaMediaTypes MediaType { get; }

    string PN { get; }

    DlnaMime Type { get; }

    Stream CreateContentStream();
  }
}
