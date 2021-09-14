using System;
namespace DelicateCalculator{
    delegate int Calculator(int n);
    
    public class DelicateCalculator{
        static int number = 10;
        
        public static int add(int n){
            number += n;
            return number;
        }
        
        public static int mul(int n){
            number *= n;
            return number;
        }
        
        public static int getNumber(){
            return number;
        }
        
        public static void Main(String[] args){
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            Console.WriteLine("before:"+getNumber());
            c1(20);
            Console.WriteLine("AFTER:"+getNumber());
            
            Console.WriteLine("before:"+getNumber());
            c2(20);
            Console.WriteLine("AFTER:"+getNumber());
            
            
        }
    }
    
}
