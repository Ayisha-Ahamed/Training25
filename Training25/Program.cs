// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that implements custom MyList<T> class using arrays as the underlying data structure. 
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      if (!TestResize ()) {
         WriteLine ("Test failed!!");
         return;
      }
      var list = new MyList<int> (10, 20, 30, 40);
      list.Display ();
      WriteLine ($"After adding 70 to the list(capacity doubled): ");
      list.Add (70);
      list.Display ();
      WriteLine ($"After inserting 30 at 3rd index position: ");
      list.Insert (3, 30);
      list.Display ();
      WriteLine ($"After removing first instance of element 30: ");
      list.Remove (30);
      list.Display ();
      WriteLine ($"After removing element at index position 2: ");
      list.RemoveAt (2);
      list.Display ();
      WriteLine ($"After clearing the list: ");
      list.Clear ();
      list.Display ();
   }

   static bool TestResize () {
      // Initialize an empty list
      var tList = new MyList<int> ();
      if (tList.Count != 0 || tList.Capacity != 4) return false;
      // Fill the array up to its default capacity.
      for (int i = 0; i < 4; i++) tList.Add (i);
      int count = tList.Count, capacity = tList.Capacity;
      if (count != 4 || count != capacity) return false;
      tList.Add (4);
      // Check whether adding elements above the default capacity doubles the capacity.
      if (tList.Capacity != (2 * capacity)) return false;
      return true;
   }

   class MyList<T> {

      #region Constructor--------------------------------------------------------------------------
      // Default constructor.
      public MyList () { }

      // Construtor to add paramter elements to the list on initialization.
      public MyList (params T[] items) {
         foreach (T item in items) Add (item);
      }
      #endregion-----------------------------------------------------------------------------------

      #region Properties---------------------------------------------------------------------------
      // Gets the count of elements in list.
      public int Count => mCount;

      // Gets the capacity of array.
      public int Capacity => mArray.Length;
      #endregion-----------------------------------------------------------------------------------

      #region Methods------------------------------------------------------------------------------
      /// <summary>Gets or sets element at given index position.</summary>
      public T this[int index] {
         get {
            ThrowIfOutOfRange (index);
            return mArray[index];
         }
         set {
            ThrowIfOutOfRange (index);
            mArray[index] = value;
         }
      }

      /// <summary>Adds element at the end of the array.</summary>
      public void Add (T item) {
         ResizeIfFull ();
         mArray[mCount++] = item;
      }

      /// <summary>Removes first occurence of given element, returns true upon removal.</summary>
      public bool Remove (T a) {
         int index = Array.IndexOf (mArray, a);
         if (index < 0) return false;
         for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
         mArray[--mCount] = default; // Reset the last index position to default value of type T.
         return true;
      }

      /// <summary>Clears all elements from array.</summary>
      public void Clear () {
         if (mCount == 0) return;
         Array.Clear (mArray);
         mCount = 0;
      }

      /// <summary>Insert element at index position.</summary>
      public void Insert (int index, T a) {
         if (index < 0 || index > mCount) throw new ArgumentOutOfRangeException ();
         ResizeIfFull ();
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = a;
         mCount++;
      }

      /// <summary>Removes element at index position.</summary>
      public void RemoveAt (int index) {
         if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException ();
         Remove (mArray[index]);
      }

      /// <summary>Prints all elements in array, if any.</summary>
      public void Display () {
         for (int i = 0; i < Count; i++) Write ($"{mArray[i]} ");
         WriteLine ($"{(mCount > 0 ? "\n" : "")}Count: {Count} Capacity: {Capacity}");
      }
      #endregion-----------------------------------------------------------------------------------

      #region Private Data ------------------------------------------------------------------------
      // Initalize an empty array with capacity to hold four elements.
      int mCount = 0;
      T[] mArray = new T[4];
      #endregion ----------------------------------------------------------------------------------

      #region Private Methods----------------------------------------------------------------------
      // Increases capacity of array if the array is full.
      void ResizeIfFull () {
         if (Count == Capacity) Array.Resize (ref mArray, Capacity * 2);
      }

      // Throws an exception if the index value is out of range.
      void ThrowIfOutOfRange (int index) {
         if (index < 0 || index >= Count) throw new IndexOutOfRangeException ();
      }
      #endregion-----------------------------------------------------------------------------------
   }
}