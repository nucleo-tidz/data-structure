namespace nucleotidz.datastructure.Stack
{
    public class Stack
    {
        int Max;
        int[] stack;
        int top = 0;
        public Stack(int _max)
        {
            Max = _max;
            stack = new int[Max];
        }

        public int[] Push(int value)
        {
            if (top >= Max)
            {
                throw new OverflowException("Stack over flow");
            }
            stack[top] = value;
            top = top + 1;
            return stack;
        }
        public int Pop()
        {
            if (top <= 0)
            {
                throw new OverflowException("Stack under flow");
            }
            return stack[--top];
        }
    }
}
