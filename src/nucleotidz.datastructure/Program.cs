﻿// See https://aka.ms/new-console-template for more information
using nucleotidz.datastructure.BST;
using nucleotidz.datastructure.LinkList;
using System.ComponentModel.Design.Serialization;
using BinarySearchTree = nucleotidz.datastructure.BST;
using LinkList = nucleotidz.datastructure.LinkList;
Console.WriteLine("Hello, World!");

CreateLinkListFromTop();

Console.ReadLine();

#region Tree
static BinarySearchTree.Node CreateTree()
{
    int[] nodeValues = { 11, 20, 8, 2, 3, 4, 50, 1 };
    BinarySearchTree.Node root = new();
    root.value = 10;
    //Create root Node
    new TreeOperation().Insert(null, root.value);

    //Create leaves
    foreach (int value in nodeValues)
    {
        new TreeOperation().Insert(root, value);
    }

    return root;
}
static void FindParent()
{
    var tree = CreateTree();
    new TreeOperation().GetParent(new BinarySearchTree.Node { value = 2 }, tree);

}
static void FindCommonParent()
{
    var tree = CreateTree();
    new TreeOperation().GetCommonParent(new BinarySearchTree.Node { value = 1 }, new BinarySearchTree.Node { value = 4 }, tree);

}

static void FindDistance()
{
    var tree = CreateTree();
    new TreeOperation().GetDistance(new BinarySearchTree.Node { value = 3 }, tree);

}

#endregion

#region Linked List

static void CreateLinkList()
{
    LinkList.Node node = new LinkedListOperation().InsertLast(null, 1);
    new LinkedListOperation().InsertLast(node, 2);
    new LinkedListOperation().InsertLast(node, 3);
    new LinkedListOperation().InsertLast(node, 4);
    new LinkedListOperation().InsertLast(node, 5);
    new LinkedListOperation().InsertLast(node, 6);
    new LinkedListOperation().InsertLast(node, 7);
    new LinkedListOperation().InsertLast(node, 8);
    new LinkedListOperation().InsertLast(node, 9);

}
static void CreateLinkListFromTop()
{
    LinkList.Node node = new LinkedListOperation().InsertFront(null, 9);
    new LinkedListOperation().InsertFront(node, 8);
    new LinkedListOperation().InsertFront(node, 7);
    new LinkedListOperation().InsertFront(node, 6);
    new LinkedListOperation().InsertFront(node, 5);
    new LinkedListOperation().InsertFront(node, 4);
    new LinkedListOperation().InsertFront(node, 3);
    new LinkedListOperation().InsertFront(node, 2);
    new LinkedListOperation().InsertFront(node, 1);

}

#endregion