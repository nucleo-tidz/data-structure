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
            Node refernceNode = GetNodebyValue(referenceValue, node);
            Node newNode = new Node(value, refernceNode.next, refernceNode);
            if (refernceNode.next is not null)
            {
                refernceNode.next.previous = newNode;
            }
            refernceNode.next = newNode;
            return node;
        }
        public Node Delete(Node node, int value)
        {
            Node refernceNode = GetNodebyValue(value, node);
            //If reference node is the first node repalce it with the next node
            if (refernceNode.previous == null)
            {
                node = refernceNode.next;
                refernceNode.previous = null;
               
            }
            //If reference node is the last node
            else if (refernceNode.next == null)
            {
                refernceNode.previous.next = null;
            }
            refernceNode.previous.next = refernceNode.next;
            refernceNode.next.previous = refernceNode.previous;
            return node;
        }

        public Node GetDuplicate(Node node)
        {
            List<int> values = new();
            values.Add(node.value);
            while (node.next != null)
            {
                if (values.Any(_ => _ == node.next.value))
                {
                    return node.next;
                }
                values.Add(node.next.value);
                node = node.next;
            }
            return null;
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
        private List<int> GetValues(Node node, List<int> values)
        {
            values ??= new();
            values.Add(node.value);
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
