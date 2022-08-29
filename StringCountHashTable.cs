namespace HashTable_BinarySearchTree
{
    public class StringCountHashTable
    {
        private class WordNode
        {
            public string Value;
            public WordNode Next;

            public WordNode(string value)
            {
                Value = value;
            }
        }

        private WordNode[] WordArray;

        public StringCountHashTable(int size)
        {
            WordArray = new WordNode[size];
        }

        public void Add(string value)
        {
            var word = new WordNode(value);
            var arrayIndex = Math.Abs(word.Value.GetHashCode()) % WordArray.Length;

            word.Next = WordArray[arrayIndex];
            WordArray[arrayIndex] = word;
        }

        public void CountOccurance(string value)
        {
            var word = new WordNode(value);
            var arrayIndex = Math.Abs(word.Value.GetHashCode()) % WordArray.Length;

            var temp = WordArray[arrayIndex];
            var count = 0;

            while (temp != null)
            {
                if (temp.Value == value)
                    count++;
                temp = temp.Next;
            }

            if(count != 0)
                Console.WriteLine("'{0}' is Repeated {1} times",value,count);
            else
                Console.WriteLine("'{0}' was not found in the record",value);
        }

        public void Delete(string value)
        {
            var arrayIndex = Math.Abs(value.GetHashCode()) % WordArray.Length;

            var currentNode = WordArray[arrayIndex];
            WordNode previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    if (currentNode == null) return;
                    if (previousNode == null)
                    {
                        WordArray[arrayIndex] = currentNode.Next;
                        currentNode = currentNode.Next;
                        continue;
                    }
                    previousNode.Next = currentNode.Next;

                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

        }

        public void Print()
        {
            for (int i = 0; i < WordArray.Length; i++)
            {
                var temp = WordArray[i];
                Console.Write("\n'Index - {0}' : ", i);
                while (temp != null)
                {
                    Console.Write(" {0} -> ", temp.Value);
                    temp = temp.Next;
                }
                Console.Write(" END ");
            }
        }
    }
}