namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State => state;
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myObject = new ClassA();
            Console.WriteLine($"myObject.State = {myObject.State}");
            var myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");
            Console.ReadKey();
        }
    }
}
