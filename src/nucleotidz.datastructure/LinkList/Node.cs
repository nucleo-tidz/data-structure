namespace nucleotidz.datastructure.LinkList
{
    public class Node
    {
        
        public int value { get; set; }
        public Node next { get; set; }
        public Node previous { get; set; }

        public Node(int _value ,Node _next,Node _previous)
        {
            value = _value;
            next = _next;
            previous = _previous;
        }
    }
}
