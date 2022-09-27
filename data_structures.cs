using System;
using System.Collections.Generic;

public class DS{
    public void LL(){
        LinkedList<int> my_list=new LinkedList<int>();
        my_list.AddLast(1);
        my_list.AddLast(2);
        my_list.AddLast(3);
        my_list.AddLast(4);
        my_list.AddFirst(5);
        my_list.AddFirst(6);
        var newNode=my_list.AddLast(8);
        my_list.AddBefore(newNode,7);
        
        foreach(int i in my_list)
        {
            Console.Write(i+"   ");
        }
        Console.WriteLine();
        
        my_list.Remove(my_list.First); //removing first element
        Console.WriteLine("After Removing First element:");
        foreach(int i in my_list)
        {
            Console.Write(i+"   ");
        }
        Console.WriteLine();
        
         my_list.Remove(5);             //deleting by value
        Console.WriteLine("After Removing element 5:");
        foreach(int i in my_list)
        {
            Console.Write(i+"   ");
        }
        Console.WriteLine();
        
        my_list.RemoveLast();       //deleting last element
        Console.WriteLine("After Removing last element:");
        foreach(int i in my_list)
        {
            Console.Write(i+"   ");
        }
        Console.WriteLine();
        
        if(my_list.Contains(2)==true) Console.WriteLine("Element 2 Found");
        else Console.WriteLine("Element not found");
    }
    
    public void DT(){
        Dictionary<int, string> dict =  new Dictionary<int, string>(); 

          dict.Add(1, "abc");
          dict.Add(2, "def");
          dict.Add(3, "hij");
            
          foreach(KeyValuePair<int, string> i in dict)
          {
              Console.WriteLine("{0} {1}", i.Key, i.Value);
          }
          
          dict.Remove(1);       //After removing specific value
          Console.WriteLine("After removing value 1");
          foreach(KeyValuePair<int, string> i in dict)
          {
              Console.WriteLine("{0} {1}", i.Key, i.Value);
          }
          
          dict.Clear();
          Console.WriteLine("Total number of key/value pairs present in dict:"+ dict.Count);
        
    }
    
    public void stk(){
        Stack<int> st = new Stack<int>();
  
        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);
        st.Push(5);
        st.Push(6);
        Console.WriteLine("Total number of elements in the Stack are : "+ st.Count);
        Console.WriteLine("Element at the top is : " + st.Peek());
        
        st.Pop();
        Console.WriteLine("After popping the top element new top is : " +st.Peek());
        
        Console.WriteLine(st.Contains(10));
    }
}

public class DataStructures {
  static void Main() {
    Console.WriteLine("******Linked List*******");
    DS d=new DS();
    d.LL();
    Console.WriteLine();
    Console.WriteLine("******Dictionary*******");
    d.DT();
    Console.WriteLine();
    Console.WriteLine("******Stack**");
    d.stk();
  }
}
