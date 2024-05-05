using System.Xml.Linq;

namespace nucleotidz.datastructure.BST
{
    public class TreeOperation
    {
        public Node Insert(Node node, int value)
        {
            if (node == null)
            {
                node = new Node();
                node.value = value;
            }
            else if (value < node.value)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.value)
            {
                node.Right = Insert(node.Right, value);
            }
            return node;
        }
        public Node GetCommonParent(Node first, Node second, Node root)
        {
            if (first.value < root.value && second.value < root.value)
            {
                GetCommonParent(first, second, root.Left);

            }
            if (first.value > root.value && second.value > root.value)
            {
                GetCommonParent(first, second, root.Right);
            }
            return root;
        }

        public Node GetParent(Node node, Node root)
        {
            if (node.value < root.value)
            {
                if (node.value != root.Left?.value)
                {
                    GetParent(node, root.Left);
                }

            }
            if (node.value > root.value)
            {
                if (node.value != root.Right?.value)
                {
                    GetParent(node, root.Right);
                }
            }
            return root;
        }
        public int GetDistance(Node node, Node root, int i = 0)
        {
            if (node.value < root.value)
            {
                i++;
                GetDistance(node, root.Left,i);

            }
            if (node.value > root.value)
            {
                i++;
                GetDistance(node, root.Right,i);

            }
            return i;
        }
    }
}
