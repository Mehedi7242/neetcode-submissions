public class Solution {
    public int CalPoints(string[] operations)
    {
        Stack<int> myStack = new Stack<int>();
        int sum = 0;
       
        foreach (string op in operations)
        {
            Console.WriteLine($"Current op = {op}");
            if (op == "C")
            {
                myStack.Pop();
            }
            if (op == "D")
            {
                myStack.Push(myStack.Peek() * 2);
            }
            if (op == "+")
            {
                int first = myStack.Pop();
                int second = myStack.Peek();

                myStack.Push(first);
                myStack.Push(first + second);
            }
            else if (int.TryParse(op, out int nums))
            {
                myStack.Push(nums);
            }
        }

        while (myStack.Count > 0)
        {
            sum += myStack.Pop();
        }
        Console.WriteLine(sum);
        return sum;

    }
}