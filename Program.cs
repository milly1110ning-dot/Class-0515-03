namespace Class_0515_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IName p1 = new Person();
            Console.WriteLine(p1.GetName());
            INumber p2= new Person();
            Console.WriteLine(p2.GetNumber());
        }
    }
}
