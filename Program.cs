namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(doSomeWork));
            thread.Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread: {0}", i);
                Thread.Sleep(10);
            }
            thread.Join();
            Console.WriteLine("Main block");
        }
        public static void doSomeWork() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Worker Thread: {0}", i);
                Thread.Sleep(100);
            }
        }
    }
}