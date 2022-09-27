using System;

public abstract class Subject{   //Abstract Class
        public abstract void sorting(); //Abstract method
    
}

public class Math: Subject{                     //Inheritance
    
        public override void sorting(){         //overridden method 
            int [] arr=new int[]{66,90,10,82,33,7,56};      //Declartion of array
            Array.Sort(arr);
            Console.WriteLine("The sorted array is as follow:");
            Console.Write("\n");
            
            foreach(int i in arr){                          //for loop
                Console.Write(i+"   ");
            }
            Console.Write("\n");
            
            Console.WriteLine("*********Addition of Two Integers**********");       //addition
            int x=5,y=10;
            Console.WriteLine("The addition of integers is "+ x+y);
            
            int a=10;
            if(a<5) Console.WriteLine("Integer is smaller than 5");             //if else statement
            else Console.WriteLine("Integer is larger than 5");
            Console.Write("\n");
        }
    
}

 public class English: Subject{
    public override void sorting(){
        
    }
    public void verb(){                 //Polymorphism
        Console.WriteLine("I'm in base class English which is derived from Subject");
        string st="Hello";
        int i=5;
        while(i>0){                     //while loop
            Console.Write(st+"  ");
            i--;
        }
        Console.Write("\n\n");
    }
 }
 
public class Grammer: English{ 
    public void verb(){             //overridden method
        Console.WriteLine("I'm in derived class Grammer which which is derived from English");
    }
}

public class Sample {
 
  public static void Main() {
    Subject s;               //Object of base class
    s=new Math();           // assigned the base class pointer to derived Math class
    s.sorting();
    
    English eg=new English();       
    eg.verb();                  //called the function with base class obj
    
    Grammer g=new Grammer();
    g.verb();                   //called the function with derived class obj

    
    //string st="Hello, I'm Aditi";
    //Console.WriteLine("The length of the string is " + st.Length());
    }
}
