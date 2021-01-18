using System;
using DesignPatterns.Singleton;

namespace DesignPatterns.Singleton
{
  public class App
  {
    public static void Main(string[] args)
    {
      var theInstance = Singleton.GetInstance();

      Console.WriteLine(String.Format("instance value: {0}", theInstance.Value));

      Console.WriteLine("Setting instance value...");
      theInstance.Value = "A new value!";

      Console.WriteLine(String.Format("instance value: {0}", theInstance.Value));
    }
  }
}