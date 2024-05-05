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
        public Node GetLastNode(Node node)
        {
            if(node.next == null)
            {
                return node;
            }
            else
            {
               return GetLastNode(node.next);
            }
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

        public Node GetFirstNode(Node node)
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
    }
}
