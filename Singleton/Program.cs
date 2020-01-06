using System;

namespace Singleton
{
    class SingletonObject
    {
        private SingletonObject()
        {
        }

        private static SingletonObject uniqueObject;

        public static SingletonObject GetInstance()
        {
            if (uniqueObject == null)
                uniqueObject = new SingletonObject();

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
