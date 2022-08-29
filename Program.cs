namespace HashTable_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------HASH TABLE---------------------------------------");

            var UC1text = "To be or not to be";
            var UC2text = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            var UC1Array = UC1text.Split(' ');
            var UC2Array = UC2text.Split(' ');

            var hTable1 = new StringCountHashTable(UC1Array.Length);
            var hTable2 = new StringCountHashTable(UC2Array.Length);

            foreach (var word in UC1Array)
                hTable1.Add(word);

            foreach (var word in UC2Array)
                hTable2.Add(word);

            Console.WriteLine("---------- Find Frequency of each word in HashTable 1 ---------- \n");
            foreach (var word in UC1Array)
                hTable1.CountOccurance(word);

            Console.WriteLine("\n ---------- Find Frequency of each word in HashTable 2 ---------- \n");
            foreach (var word in UC2Array)
                hTable2.CountOccurance(word);

            Console.WriteLine("\n ---------- Delete 'Avoidable' from HashTable 2 ---------- \n");
            hTable2.Delete("avoidable");
            hTable2.CountOccurance("avoidable");
            hTable2.Print();

            Console.WriteLine("\n----------------------------Binary Search Tree---------------------------------------");

            var BST = new BinarySearchTree();
            BST.Add(56);
            BST.Add(30);
            BST.Add(70);
            BST.Add(22);
            BST.Add(40);
            BST.Add(11);
            BST.Add(16);
            BST.Add(3);
            BST.Add(60);
            BST.Add(95);
            BST.Add(65);
            BST.Add(63);
            BST.Add(67);

            Console.WriteLine(BST);

            Console.WriteLine("\n Search 63 and 111 in the Tree");

            BST.Search(63);
            BST.Search(111);
        }
    }
}