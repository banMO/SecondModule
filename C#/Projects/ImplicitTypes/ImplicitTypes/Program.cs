using System;

namespace ImplicitTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * var number = 2;

                var enumF = MyEnum.None;
                 enum MyEnum
                {
                    None = 0;
            
                }
                Console.WriteLine(number);
            */
            var myClass = new MyClass();
            var anon = new { FirstProperty = myClass, SecondProperty = "hello" };
            anon.FirstProperty.MyProperty = 1;
            //Console.Write(anon.FirstProperty);

            /*MyClass myClass = null;
             * esta bien porque son referencias
            var anon = new { FirstProperty = myClass, SecondProperty = "hello" };*/

            //NULLABLE TYPE --->use when write the endpoints for example 
            //POST api/v1/users
            //http 
            /*
             * Json Schemas
                Body
                {
                    "name": "pepe"
                    "imported": "true"
                }

                class user
                {
                  name 
                }
             
             */

          /*  
           *  NULLABLE TYPE
           *  int? num = 10;
            if(num.HasValue)
            {
                System.Console.WriteLine(num.Value);
            }
            else
            {
                System.Console.WriteLine("UNDEFINED");
            }
            */
            int? a = null;
            System.Console.WriteLine(a.GetValueOrDefault());
            System.Console.WriteLine(default(int));
            //int m1 = n;

            int? c = null;
            int d = c?? -1;
            System.Console.WriteLine(d);
        }

        class MyClass
        {
            public int MyProperty { get; set; }
        }
    }
}