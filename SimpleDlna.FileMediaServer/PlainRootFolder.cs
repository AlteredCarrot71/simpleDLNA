using System.IO;
using SimpleDlna.Server;

namespace SimpleDlna.FileMediaServer
{
  internal sealed class PlainRootFolder : PlainFolder
  {
    internal PlainRootFolder(FileServer server, DirectoryInfo di)
      : base(server, null, di)
    {
      Id = Identifiers.GENERAL_ROOT;
    }
  }
}
