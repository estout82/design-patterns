using System;

namespace DesignPatterns.Singleton
{
  public class Instance
  {
    public Instance() { Value = "Default"; }

    public string Value
    {
      get; set;
    }
  }
}