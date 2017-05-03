using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CA2
{
    class Menu
    {

        private static string instructions = "Please Enter:\n[1] Shortest Path\n[0] Exit";

        public static void printList(AdjacencyList adj)
        {
            for (int i = 0; i < adj.getLength(); i++)
            {
                if (adj.getNeighbours(i).Count == 0)
                {
                    continue;
                }

                String neighbours = "";
                foreach (int j in adj.getNeighbours(i))
                {
                    neighbours += j + " ";
                }
                Console.WriteLine("Node " + (i + 1) + ":\n" + neighbours + "\n\n");
            }
        }

        public static void menuLoop()
        {
            int choice = -1;

            while(choice != 0)
            {
                Console.WriteLine(instructions);
                choice = Int32.Parse(Console.ReadLine());



            }

        }

        public static void Main(string[] Args)
        {
            List<int>[] v = new List<int>[10];

            for (int i = 0; i < 10; i++)
            {
                v[i] = new List<int>();
            }

            v[0] = new List<int>() { 7, 1 };
            v[1] = new List<int>() { 0, 6 };
            v[2] = new List<int>() { 3, 4, 5, 6 };
            v[3] = new List<int>() { 2, 4, 6 };
            v[4] = new List<int>() { 2, 3, 5 };
            v[5] = new List<int>() { 2, 4 };
            v[6] = new List<int>() { 1, 2, 3 };
            v[7] = new List<int>() { 0 };

            AdjacencyList adj = new AdjacencyList(v);

            Menu.printList(adj);

            adj.shortestPath(2, 5);
        }
    }
}
