﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using MVVM.Client.Data.DataServices;

namespace MVVM.Client.Data
{
  public class GameLoadingEventArgs : EventArgs
  {
    public IEnumerable<Game> Results { get; private set; }

    public GameLoadingEventArgs(IEnumerable<Game> results)
    {
      Results = results;
    }
  }
}
