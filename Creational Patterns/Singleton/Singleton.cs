using System;

namespace DesignPatterns.Singleton
{
    //here there are many ways to create 
    /*
     * In real world system using new for creating instance is costly in case of
     * complex and big system/class
     *
     * when to use
     * in caching, in centralized system, in common log, in complex system
     *
     * usefulness
     * in bigger class where using new is complex, sometime we might need to use
     * same or one instance of class everywhere 
     */
    public class Singleton
    {
        
    }

    public sealed class SingletonOne
    {
        private static readonly SingletonOne Instance;

        private SingletonOne()
        {
            Console.WriteLine("This is a private constructor");
        }

        static SingletonOne()
        {
            if(Instance == null)
            {
                Instance = new SingletonOne();
            }
        }
        public static SingletonOne GetInstance => Instance;
    }

    public sealed class SingletonTwo
    {
        private static readonly SingletonTwo Instance=new SingletonTwo();

        private SingletonTwo()
        {
        }
        public static SingletonTwo GetInstance
        {
            get { return Instance; }
        }
    }
    public class SingletonThree
    {
        private static readonly SingletonThree Instance;

        private SingletonThree()
        {
            Console.WriteLine("This is a private constructor");
        }

        static SingletonThree()
        {
            if(Instance == null)
            {
                Instance = new SingletonThree();
            }
        }

        public static SingletonThree GetInstance => Instance;
    }
    public sealed class SingletonFour
    {
        private static readonly SingletonFour Instance=new SingletonFour();

        private SingletonFour()
        {
        }
        public static SingletonFour GetInstance
        {
            get { return Instance; }
        }
    }

    public class SingletonFive //can be sealed
    {
        private static readonly SingletonFive Instance;

        private SingletonFive() {
        }

        static SingletonFive()
        {
            if (Instance == null)
            {
                Instance = new SingletonFive();
            }
        }
        public static SingletonFive GetInstance => Instance;

    }
    public class SingletonSix //can be sealed
    {
        private static readonly SingletonSix Instance;
        private static object objectForLock = new object();
        private SingletonSix() {
        }

        static SingletonSix()
        {
            lock (objectForLock)
            {
                if (Instance == null)
                {
                    Instance = new SingletonSix();
                }
            }
        }
        public static SingletonSix GetInstance => Instance;

    }
    public class SingletonSeven //can be sealed
    {
        private static readonly SingletonSeven Instance;
        private static object objectForLock = new object();
        private SingletonSeven() {
        }

        static SingletonSeven()
        {
            if (Instance == null)
            {
                lock (objectForLock)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonSeven();
                    }
                }
            }
        }
        public static SingletonSeven GetInstance => Instance;

    }

}