using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree<char> tree = new BinaryTree<char>();

        tree.AddLeft(-1, 'A');
        tree.AddLeft(0, 'B');
        tree.AddLeft(1, 'C');
        tree.AddRight(0, 'D');
        tree.AddLeft(3, 'E');
        tree.Remove(1);

        for(int i=0; i<tree.GetLength(); i++)
        {
            Console.WriteLine(tree.Get(i));
        }
    }
}