// See https://aka.ms/new-console-template for more information
using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("hello everyone");
            GreetWhite();
            GreetBlack();
        }
        
        static void GreetWhite()
        {
            Console.Writeline("hello white");
        }
        
        static void GreetBlack()
        {
            Console.Writeline("hello black");
        }
    }
}