using System.IO;

namespace SimpleDlna.Server
{
  internal interface IResponse
  {
    Stream Body { get; }

    IHeaders Headers { get; }

    HttpCode Status { get; }
  }
}
