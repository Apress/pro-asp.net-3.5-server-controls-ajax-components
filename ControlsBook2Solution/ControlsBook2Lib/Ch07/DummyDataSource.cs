// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 7 - Server Control Data Binding
// File: DummyDataSource.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.Collections;

namespace ControlsBook2Lib.Ch07
{
   internal sealed class DummyDataSource : ICollection
   {
      public DummyDataSource(int dataItemCount)
      {
         this.Count = dataItemCount;
      }

      public int Count { get; set; }

      public bool IsReadOnly
      {
         get
         {
            return false;
         }
      }

      public bool IsSynchronized
      {
         get
         {
            return false;
         }
      }

      public object SyncRoot
      {
         get
         {
            return this;
         }
      }

      public void CopyTo(Array array, int index)
      {
         for (IEnumerator e = this.GetEnumerator(); e.MoveNext();)
            array.SetValue(e.Current, index++);
      }

      public IEnumerator GetEnumerator()
      {
         return new DummyDataSourceEnumerator(Count);
      }

      private class DummyDataSourceEnumerator : IEnumerator
      {
         private int count;
         private int index;

         public DummyDataSourceEnumerator(int count)
         {
            this.count = count;
            this.index = -1;
         }

         public object Current
         {
            get
            {
               return null;
            }
         }

         public bool MoveNext()
         {
            index++;
            return index < count;
         }

         public void Reset()
         {
            this.index = -1;
         }
      }
   }
}
