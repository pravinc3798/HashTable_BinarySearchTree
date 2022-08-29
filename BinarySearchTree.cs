namespace HashTable_BinarySearchTree
{
    public class BinarySearchTree
    {
        private class Node
        {
            public int Value;
            public Node Right;
            public Node Left;

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node Root;

        public void Add(int value)
        {
            Root = InsertRecursively(Root, value);
        }

        private Node InsertRecursively(Node currentNode, int value)
        {
            if (currentNode == null)
                currentNode = new Node(value);

            else if (value > currentNode.Value)
                currentNode.Right = InsertRecursively(currentNode.Right, value);

            else
                currentNode.Left = InsertRecursively(currentNode.Left, value);

            return currentNode;
        }

        public void Search(int value)
        {
            SearchRecursively(Root, value);
        }

        private void SearchRecursively(Node currentNode, int value)
        {
            if (currentNode == null)
                Console.WriteLine(" '{0}' Not found in the Tree",value);

            else if (currentNode.Value == value)
                Console.WriteLine(" '{0}' Present in the Tree",value);

            else if (value > currentNode.Value)
                SearchRecursively(currentNode.Right, value);

            else
                SearchRecursively(currentNode.Left, value);
        }

        public override string ToString()
        {
            return Print(Root, 0);
        }

        private string Print(Node currentNode, int l)
        {
            // copied from google and not able to understand the logic as of today (20/8/22)

            string res = (currentNode == null) ? "NULL" : currentNode.Value.ToString();
            res = $"{"".PadRight(1, '-')}{res}\n";

            if (currentNode == null) return res;

            res += $"{Print(currentNode.Left, l + 1)}";
            res += $"{Print(currentNode.Right, l + 1)}";

            return res;
        }
    }
}