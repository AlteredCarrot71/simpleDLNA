using System.IO;
using SimpleDlna.Server;

namespace SimpleDlna.Thumbnails
{
  internal interface IThumbnailLoader
  {
    DlnaMediaTypes Handling { get; }

    MemoryStream GetThumbnail(object item, ref int width, ref int height);
  }
}
