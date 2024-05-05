namespace nucleotidz.datastructure.BST
{
    public class Tree
    {
        public Node Insert(Node node,int value)
        {
            if (node == null)
            {
                node = new Node();
                node.value = value;
            }
            else if( value< node.value)
            {
                node.Left=Insert(node.Left ,value);
            }
            else if (value > node.value)
            {
                node.Right = Insert(node.Right, value);
            }
            return node;
        }
    }
}
