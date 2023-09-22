namespace SimpleDlna.Server
{
  internal interface IPrefixHandler : IHandler
  {
    string Prefix { get; }
  }
}
