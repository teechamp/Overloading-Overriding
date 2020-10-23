﻿using System;

namespace Overrriding
{   
                class Class1
            {
                public virtual void show()
                {
                    Console.WriteLine("Super class show method");
                }
            }
     class Class2 : Class1
            {
                public override void show()
                {
                    Console.WriteLine("Sub class override show method");
                }
            }

    
            class Program
                {
            
            static void Main(string[] args)
                {
                    Class2 obj = new Class2();
                    obj.show();
                    Console.ReadKey();
               }
         
    }   
}
