﻿using SingletonDesignPattern.Naive;
using SingletonDesingPattern.ThreadSafe;

class Program
{
    static void Main(string[] args)
    {
        #region Naive Singleton
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        #endregion

        #region ThreadSafe
        // The client code.

        Console.WriteLine(
            "{0}\n{1}\n\n{2}\n",
            "If you see the same value, then singleton was reused (yay!)",
            "If you see different values, then 2 singletons were created (booo!!)",
            "RESULT:"
        );

        Thread process1 = new Thread(() =>
        {
            TestSingleton("FOO");
        });
        Thread process2 = new Thread(() =>
        {
            TestSingleton("BAR");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();
        #endregion
    }

    public static void TestSingleton(string value)
    {
        ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
}