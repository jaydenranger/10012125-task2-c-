using System;

namespace task2c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display the division tables of 1 to 12 based on your number input");

            Console.WriteLine("enter a number");
            var num1 = int.Parse(Console.ReadLine());

            if(num1<100){
                var count = 12;
                for(var i = 0; i<count;i++){
                    var a = i+1;
                    Console.WriteLine($"{num1}/{a}={Convert.ToDouble(num1)/a}");

                } 
               

            }else{

                   
            Console.WriteLine("The number you entered is greater than 100");
            }
        }
    }
}
