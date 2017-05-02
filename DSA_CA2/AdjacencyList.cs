using System;
using System.Collections.Generic;

namespace DSA_CA2
{

   class AdjacencyList
    {

        List<int>[] verteces;
        Dictionary<int, int> parent;
        Dictionary<int, int> level;

        public AdjacencyList (List<int>[] v)
        {
            this.verteces = v;
        }


        public void printAL(List<int> list)
        {

            Console.Write("Printing List Size: ");
            Console.WriteLine(list.Count);


            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void shortestPath(int s, List<int> verts)
        {
            

        }

        public void BFS(int s, List<int>[] verts)
        {

            // level is a dictionary of verteces that have been assigned a level.
            // S is the start node, so is assigned level 0.
            Dictionary<int, int> level = new Dictionary<int, int>();
            level.Add(s, 0);

            // Parent is a dictionary of verteces and their parent nodes.
            // S is the start node, it has no parent.      
            Dictionary<int, int> parent = new Dictionary<int, int>();
            parent.Add(s, -1);

            // Next is every node thats reachable in i steps.
            List<int> next = new List<int>();
            
            // frontier is a list of everything reachable in i-1 steps.
            List<int> frontier = new List<int>() {s};
            
            // i is an iteration counter.
            int i = 1;

            while (!(frontier.Count == 0))
            {
                next = new List<int>();
                foreach (int u in frontier)
                    foreach (int v in verts[u])
                    {
                        // If int v is not in levels   
                        if (!level.ContainsKey(v))
                        {
                            level.Add(v, i);
                            parent.Add(v, u);
                            next.Add(v);
                        }
                    }

                frontier = next;
                i++;
                printAL(frontier);
            }      
        }
    }

    class TestGraph
    {
        public static void Main() {

            List<int>[] v = new List<int>[10];

            for (int i = 0; i < 10; i++)
            {
                v[i] = new List<int>();
            }

            v[0] = new List<int>() {7, 1};
            v[1] = new List<int>() {0, 6};
            v[2] = new List<int>() {3, 4, 5, 6};
            v[3] = new List<int>() {2, 4, 6};
            v[4] = new List<int>() {2, 3, 5};
            v[5] = new List<int>() {2, 4};
            v[6] = new List<int>() {1, 2, 3};
            v[7] = new List<int>() {0};

            AdjacencyList adj = new AdjacencyList(v);

            adj.BFS(1, v);
        }
    }
}
