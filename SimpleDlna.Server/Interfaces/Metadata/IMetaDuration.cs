using System;

namespace SimpleDlna.Server.Metadata
{
  public interface IMetaDuration
  {
    TimeSpan? MetaDuration { get; }
  }
}
