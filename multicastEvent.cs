using System;
namespace delegate_custom_multicast{
    class Program{
        public delegate void myDelegate(int a,int b);
        
        public class XX{
            public event myDelegate myEvent;
            public void raiseEvent(int a, int b){
                myEvent(a,b);
                Console.WriteLine("Event Raised.");
            }
            public void display(int a,int b){
                Console.WriteLine("Display method called a : {0} b : {1}",a,b);
            }
            public void add(int a, int b){
                Console.WriteLine("Add method called:{0}+{1}={2}",a,b,a+b);
            }
            public void subtract(int a , int b){
                Console.WriteLine("subtract method called:{0}-{1}={2}",a,b,a-b);
            }
        }
        static void Main(String[] args){
            XX obj = new XX();
            obj.myEvent += new myDelegate(obj.display);
            obj.myEvent += new myDelegate(obj.add);
            obj.myEvent += new myDelegate(obj.subtract);
            obj.raiseEvent(50,10);
            
        }
    }
    
}
