using ConsoleApp15;

namespace ConsoleApp15Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class D : A
    {
        public void M()
        {
            A a1 = new A();
            int x = a1.p2;
            //x = a1.p1;
            //x = a1.p3;
            x = p4;
            x = p5;
        }
    }
    public class E
    {
        public void M()
        {
            A a1 = new A();
            //var x = a1.p5;
            var x = a1.p2;
        }
    }
}
