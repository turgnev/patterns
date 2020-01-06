using System;

namespace Singleton
{
    class SingletonObject
    {
        private SingletonObject()
        {
        }

        private static SingletonObject uniqueObject;
        private static Object lockObj = new Object();

        public static SingletonObject GetInstance()
        {
            if (uniqueObject == null)
            {
                lock (lockObj)
                {
                    if (uniqueObject == null)
                        uniqueObject = new SingletonObject();
                }
            }

            return uniqueObject;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingletonObject a = SingletonObject.GetInstance();
            SingletonObject b = SingletonObject.GetInstance();

            Console.ReadKey();
        }
    }
}
