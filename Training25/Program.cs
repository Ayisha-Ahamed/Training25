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
      var list = new MyList<int> (10, 10, 20);
      Write ("Initial list: ");
      list.Print ();
      Write ("After inserting 40 at 2nd index position: ");
      list.Insert (2, 40);
      list.Print ();
      WriteLine ($"Element at index position 2 is: {list[2]}");
      Write ("After inserting 30 at 3rd index position: ");
      list.Insert (3, 30);
      list.Print ();
      Write ("After removing first instance of element 10: ");
      list.Remove (10);
      list.Print ();
      Write ("After removing element at index position 2: ");
      list.RemoveAt (2);
      list.Print ();
      list.Clear (); // Clear all elements from the array.
      list.Print ();
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
         if (Count == Capacity) Array.Resize (ref mArray, Capacity * 2);
         mArray[mCount++] = item;
      }

      /// <summary>Removes first occurence of given element, returns true upon removal.</summary>
      public bool Remove (T a) {
         int index = Array.IndexOf (mArray, a);
         if (index < 0) return false;
         RemoveAt (index);
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
         if (Count == Capacity) Array.Resize (ref mArray, Capacity * 2);
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = a;
         mCount++;
      }

      /// <summary>Removes element at index position.</summary>
      public void RemoveAt (int index) {
         if (index < 0 || index > mCount - 1) throw new ArgumentOutOfRangeException ();
         if (Count == Capacity) Array.Resize (ref mArray, Capacity * 2);
         for (int i = index; i < mCount; i++) mArray[i] = mArray[i + 1];
         mCount--;
      }

      /// <summary>Prints all elements in array, if any.</summary>
      public void Print () {
         if (Count == 0) return;
         for (int i = 0; i < Count; i++) Write ($"{mArray[i]} ");
         WriteLine ();
      }
   }
}