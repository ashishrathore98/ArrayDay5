using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Things in Collection: ArrayList, Hastable, SortedList
            //ArrayList arrayList=new ArrayList();
            //Hashtable hashtable = new Hashtable();
            //SortedList sortedList = new SortedList();


            Console.WriteLine("Welcome to Collection!!");
            //ArrayList arrayList = new ArrayList(); //change the size dynamically by use of ArrayList

            //create object of class Syntax
            // ClassName objectName = new ClassName();

            //accessing member/property Syntax
            // objectName.MemberName;
            //objectName.PropertyName;
            //objectName.MethodName;

            //ArrayList arrayList = new ArrayList
            //{
            //    "Sam",
            //    "Ravi",
            //    "Amit"
            //};
            //Console.WriteLine("Before: # of Elements in Array List are: "+arrayList.Count);
            //Console.WriteLine("Before: Capacity of Array List: " + arrayList.Capacity); // how many elements arrayList can handle at any instant

            //arrayList.Add("Zenia");
            //arrayList.Add("Sunita");
            //arrayList.Add("Zoya");
            //arrayList.Add("Alia");
            //Console.WriteLine("\n");
            //Console.WriteLine("After adding more elements in Array List");
            //Console.WriteLine("After: # of Elements in Array List are: " + arrayList.Count);
            //Console.WriteLine("After :Capacity of Elements in Array List are: " + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Sort();  //ascending order
            //Console.WriteLine("*Sorted Array List**");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Reverse the list");
            //arrayList.Reverse();
            //Console.WriteLine("*ArrayList in Descending Order*");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();


            // ArrayList arrayList = new ArrayList { 12, 45, 30, 11 };

            //Console.WriteLine("# List");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //arrayList.Reverse();
            //Console.WriteLine("**** Reverse # List****");
            //foreach(int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //arrayList.Sort();
            //Console.WriteLine("**Sorted # List****");
            //foreach(int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("# List");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.RemoveAt(3);// remove value from index #
            //Console.WriteLine("after removing from Index 3");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //arrayList.Remove(45);  //removing value i.e,45
            //Console.WriteLine("After removing 45");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();


            // Arraylist eg:-

            //ArrayList hardwareList=new ArrayList();
            //hardwareList.Add("CD");
            //hardwareList.Add("Printer");
            //hardwareList.Add("KeyBoard");
            //hardwareList.Add("Mouse");
            //hardwareList.Add("Network Card");
            //Console.WriteLine("Initial H/W List");
            //for(int i=0; i<hardwareList.Count; i++)
            //{
            //    Console.WriteLine(hardwareList[i]);
            //}
            //Console.WriteLine("Enter item to search & update");
            //string searchItem=Console.ReadLine();
            //int index=hardwareList.IndexOf(searchItem);
            //if(index==1)
            //{
            //    Console.WriteLine($"No such Item {searchItem} exists in Hardware List");
            //}
            //else
            //{
            //    Console.WriteLine("Enter update item");
            //    hardwareList[index] = Console.ReadLine();
            //    Console.WriteLine("Update Hardware List is as follows!!");
            //    for (int i=0;i< hardwareList.Count;i++)
            //    {
            //        Console.WriteLine(hardwareList[i]);
            //    }
            //}

            // User input to add in the arraylist eg:-

            //ArrayList hardwareList = new ArrayList();
            //hardwareList.Add("CD");
            //hardwareList.Add("Printer");
            //hardwareList.Add("KeyBoard");
            //hardwareList.Add("Mouse");
            //hardwareList.Add("Network Card");
            //Console.WriteLine("Initial H/W List");
            //for (int i = 0; i < hardwareList.Count; i++)
            //{
            //    Console.WriteLine(hardwareList[i]);
            //}
            //string newItem;
            //Console.WriteLine("Enter new Item");
            //newItem = Console.ReadLine();
            //hardwareList.Add(newItem);
            //Console.WriteLine("List after adding new Hardware");
            //for (int i = 0; i < hardwareList.Count; i++)
            //{
            //    Console.WriteLine(hardwareList[i]);
            //}
            //Console.ReadKey();

            //Hastable egs:-      Represents a collection of key/value pairs that are organized based on the hash code of the key.

            Hashtable hardware = new Hashtable() { { 1, "CD" }, { 2, "DVD" }, { 3, "KeyBoard" }, { 4, "Mouse" } };
            Console.WriteLine("List of Keys");
            foreach (var k in hardware.Keys)
            { Console.WriteLine(k); }
            Console.WriteLine("List of Values");
            foreach (var v in hardware.Values)
            { Console.WriteLine(v); }

            Console.WriteLine("Hardware Key\t Name of Hardware");
            foreach (var k in hardware.Keys)
            {
                Console.WriteLine(k + "\t \t " + hardware[k]);
            }
            Console.ReadKey();

        }
    }
}