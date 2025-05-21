using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1_3
{
    internal class Tree
    {
        public int Value { get; set; }
        public List<Tree> Children { get; set; }

        public Tree(int value)
        {
            Value = value;
            Children = new List<Tree>();
        }

        public void AddChild(Tree child)
        {
            Children.Add(child);
        }

        public void PrintChildren()
        {
            Console.Write($"Children of node {Value}: ");
            foreach (var child in Children)
            {
                Console.Write($"{child.Value} ");
            }
            Console.WriteLine();

            foreach (var child in Children)
            {
                child.PrintChildren();
            }
        }
    }
}
