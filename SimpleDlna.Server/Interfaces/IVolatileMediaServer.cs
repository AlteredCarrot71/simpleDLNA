﻿using System;

namespace SimpleDlna.Server
{
  public interface IVolatileMediaServer
  {
    bool Rescanning { get; set; }

    void Rescan();

    event EventHandler Changed;
  }
}
