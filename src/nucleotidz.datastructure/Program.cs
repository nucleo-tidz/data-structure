// See https://aka.ms/new-console-template for more information
using nucleotidz.datastructure.BST;

Console.WriteLine("Hello, World!");
CreateTree();
Console.ReadLine();

static void CreateTree()
{
    int[] nodeValues= { 11, 20, 8, 2, 3, 4, 50, 1 };
    Node root = new();
    root.value = 10;
    //Create root Node
    new Tree().Insert(null, root.value);

    //Create leaves
    foreach (int value in nodeValues)
    {
        new Tree().Insert(root, value);
    }
}