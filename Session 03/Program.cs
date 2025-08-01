namespace Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------- Vedio 01 ------------------------------------------
            // Create Object | Intance from Car
            Car C1;
            // 1. Allocate 4 bytes in Stack [Null]
            //C1 = new Car(0,"BMW",500);

            //Console.WriteLine(C1);
            //Console.WriteLine(C1.ToString());

            //---------------------------------------- Vedio 02 ------------------------------------------
            //C1 = new Car(10);
            C1 = new Car(10);
            Console.WriteLine(C1);
        }
    }
}
