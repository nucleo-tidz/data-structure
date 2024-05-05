// See https://aka.ms/new-console-template for more information
using nucleotidz.datastructure.BST;
using System.ComponentModel.Design.Serialization;

Console.WriteLine("Hello, World!");
FindDistance();


Console.ReadLine();

static Node CreateTree()
{
    int[] nodeValues = { 11, 20, 8, 2, 3, 4, 50, 1 };
    Node root = new();
    root.value = 10;
    //Create root Node
    new Tree().Insert(null, root.value);

    //Create leaves
    foreach (int value in nodeValues)
    {
        new Tree().Insert(root, value);
    }

    return root;
}
static void FindParent()
{
    var tree = CreateTree();
    new Tree().GetParent(new Node { value = 2 }, tree);

}
static void FindCommonParent()
{
    var tree = CreateTree();
    new Tree().GetCommonParent(new Node { value = 1 }, new Node {value= 4 }, tree);

}

static void FindDistance()
{
    var tree = CreateTree();
    new Tree().GetDistance(new Node { value = 3 }, tree);

}