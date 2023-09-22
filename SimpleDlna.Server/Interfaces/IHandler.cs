namespace SimpleDlna.Server
{
  internal interface IHandler
  {
    IResponse HandleRequest(IRequest request);
  }
}
