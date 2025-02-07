namespace _23_Generics_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*object[] test = { 1, 2.5, "test", true };
            foreach (object obj in test)
            {
                //Console.WriteLine(obj);
                if (obj is int)
                    Console.WriteLine((int)obj+1);
                if (obj is double)
                    Console.WriteLine((double)obj+1);
            }
            */
            MyStack<int> stack = new MyStack<int>(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }

        }
    }
}
