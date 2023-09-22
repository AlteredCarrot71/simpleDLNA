using System.IO;
using SimpleDlna.Server;

namespace SimpleDlna.FileMediaServer
{
  internal sealed class DeserializeInfo
  {
    public FileInfo Info;

    public FileServer Server;

    public DlnaMime Type;

    public DeserializeInfo(FileServer server, FileInfo info, DlnaMime type)
    {
      Server = server;
      Info = info;
      Type = type;
    }
  }
}
