using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nucleotidz.datastructure.LinkList
{
    public class LinkedListOperation
    {
        public Node InsertLast(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value, default, default);
            }
            else
            {
                Node lastNode = GetLastNode(node);
                lastNode.next = new Node(value, null, lastNode);
            }

            return node;
        }

        public Node InsertFront(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value, default, default);
            }
            else
            {
                Node firstNode = GetFirstNode(node);
                firstNode.previous = new Node(value, firstNode, null);
            }
            return node;
        }

        public Node InsertAfter(Node node, int value, int referenceValue)
        {
            List<int> values = new();
            values.Add(value);
            Node refernceNode = GetNodebyValue(referenceValue, node);
            values.AddRange(GetValues(refernceNode));

            // Make next null of reefence and rebalnce by running insert last after it
            refernceNode.next = null;
            foreach (int val in values)
            {
                InsertLast(refernceNode, val);
            }
            return node;
        }

        public Node Delete(Node node, int value)
        {
            Node refernceNode = GetNodebyValue(value, node);
            refernceNode.previous.next = refernceNode.next;
            refernceNode.next.previous = refernceNode.previous;
            return node;
        }

        private Node GetLastNode(Node node)
        {
            if (node.next == null)
            {
                return node;
            }
            else
            {
                return GetLastNode(node.next);
            }
        }
        private List<int> GetValues(Node node)
        {
            List<int> values = new();
            while (node.next != null)
            {
                values.Add(node.next.value);
                node = node.next;
            }
            return values;
        }

        private Node GetFirstNode(Node node)
        {
            if (node.previous == null)
            {
                return node;
            }
            else
            {
                return GetFirstNode(node.previous);
            }
        }
        private Node GetNodebyValue(int value, Node node)
        {
            if (node.value == value)
            {
                return node;
            }
            else
            {
                return GetNodebyValue(value, node.next);
            }
        }
    }
}
