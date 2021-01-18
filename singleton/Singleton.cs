using System;
using DesignPatterns.Singleton;

namespace DesignPatterns.Singleton
{
  public sealed class Singleton
  {
    private static Instance instance;

    private Singleton() { }

    public static Instance GetInstance()
    {
      if (instance == null)
      {
        instance = new Instance();
      }

      return instance;
    }

    public static void SetValue(string value)
    {
      Instance inst = GetInstance();
      inst.Value = value;
    }
  }
}