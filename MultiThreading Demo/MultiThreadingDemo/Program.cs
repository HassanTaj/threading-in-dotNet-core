using System;
using System.Threading;

namespace MultiThreadingDemo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Threads Execution Starts");

            new Thread(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"Thread One irritation {i}");
                    Thread.Sleep(500);
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"Thread two irritation {i}");
                    Thread.Sleep(500);
                }
            }).Start();
               
        }
    }
}