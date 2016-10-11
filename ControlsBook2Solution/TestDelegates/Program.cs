// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 5 - Server Control Events
// File: Program.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;

namespace ControlsBook2.Ch05
{
  delegate void SimpleMulticastDelegate(int i);

  public class DelegateImplementorClass
  {
    public void ClassMethod(int i)
    {
      Console.WriteLine("You passed in " + i.ToString() + " to the class method");
    }

    static public void StaticClassMethod(int j)
    {
      Console.WriteLine("You passed in " + j.ToString() + " to the static class method");
    }

    public void YetAnotherClassMethod(int k)
    {
      Console.WriteLine("You passed in " + k.ToString() + " to yet another class method");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DelegateImplementorClass ImpClass = new DelegateImplementorClass();

      SimpleMulticastDelegate d = new SimpleMulticastDelegate(ImpClass.ClassMethod);
      d(5);
      Console.WriteLine("");

      d += new SimpleMulticastDelegate(DelegateImplementorClass.StaticClassMethod);
      d(10);
      Console.WriteLine("");

      d += new SimpleMulticastDelegate(ImpClass.YetAnotherClassMethod);
      d(15);
      Console.Read();
    }
  }
}