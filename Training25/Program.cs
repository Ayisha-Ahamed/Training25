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
      var list = new MyList<int> (10, 20, 30, 40, 50);
      WriteLine ($"Initial list: {list.ListInfo ()}");
      list.Add (70);
      WriteLine ($"After adding 70 to the list(capacity doubled): {list.ListInfo ()}");
      list.Insert (3, 30);
      WriteLine ($"After inserting 30 at 3rd index position: {list.ListInfo ()}");
      list.Remove (10);
      WriteLine ($"After removing first instance of element 10: {list.ListInfo ()}");
      list.RemoveAt (2);
      WriteLine ($"After removing element at index position 2: {list.ListInfo ()}");
      list.Clear (); // Clear all elements from the array.
      WriteLine ($"After clearing the list: {list.ListInfo ()}");
   }

   static bool TestResize () {
      // Initialize an empty list with capacity to hold 5 elements(default array capacity in MyList).
      var tList = new MyList<int> ();
      if (tList.Count != 0 || tList.Capacity != 5) return false;
      // Fill the array up to its default capacity.
      for (int i = 0; i < 5; i++) tList.Add (i);
      int count = tList.Count, capacity = tList.Capacity;
      if (count != 5 || count != capacity) return false;
      tList.Add (5);
      // Check whether adding elements above the default capacity doubles the capacity of the array.
      if (tList.Capacity != (2 * capacity)) return false;
      return true;

   }

   class MyList<T> {
      int mCount;
      T[] mArray;
      // Constructor to initialize array with zero elements and capacity to hold 5 elements.
      public MyList (params T[] items) {
         mCount = 0;
         mArray = new T[5]; // Initiaize an array of size 5.
         foreach (T item in items) Add (item);
      }

      // Gets the count of elements in list.
      public int Count => mCount;

      // Gets the capacity of array.
      public int Capacity => mArray.Length;

      /// <summary>Gets or sets element at given index position.</summary>
      public T this[int index] {
         get {
            if (index < 0 || index >= Count) throw new IndexOutOfRangeException ();
            return mArray[index];
         }
         set {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ();
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
         ResizeIfFull ();
         for (int i = index; i < mCount; i++) mArray[i] = mArray[i + 1];
         mCount--;
         return true;
      }

      /// <summary>Clears all elements from array.</summary>
      public void Clear () {
         if (mCount == 0) return;
         Array.Clear (mArray);
         mCount = 0;
         mArray = new T[5]; // Set array capacity to default.
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
      public string ListInfo () {
         string str = "\n";
         for (int i = 0; i < Count; i++) str += $"{mArray[i]} ";
         str += $"{(mCount > 0 ? "\n" : "")}Count: {Count} Capacity: {Capacity}";
         return str;
      }

      // Increases capacity of array if the array is full.
      void ResizeIfFull () {
         if (Count == Capacity) Array.Resize (ref mArray, Capacity * 2);
      }
   }
}