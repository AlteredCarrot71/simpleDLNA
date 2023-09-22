using SimpleDlna.Utilities;

namespace SimpleDlna.Server.Views
{
  public interface IView : IRepositoryItem
  {
    IMediaFolder Transform(IMediaFolder oldRoot);
  }
}
