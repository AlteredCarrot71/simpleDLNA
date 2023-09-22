using System;

namespace SimpleDlna.Server.Metadata
{
  public interface IMetaInfo
  {
    DateTime InfoDate { get; }

    long? InfoSize { get; }
  }
}
