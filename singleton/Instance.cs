using System;

namespace DesignPatterns.Singleton
{
  public class Instance
  {
    private string value;

    public Instance(string value = "Default")
    {
      this.value = value;
    }

    public string Value
    {
      get { return value; }
    }
  }
}