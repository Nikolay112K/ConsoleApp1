using System;
using ConsoleApp1.AccountSpace;
using SomeStrangeClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(4);
            Person tom = new Person { name = "Tom", age = 35 };
        }
    }

    namespace AccountSpace
    {
        class Account
        {
            public int Id { get; private set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }
    }
}