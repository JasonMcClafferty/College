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
            Console.Write("\nPrinting List \nSize: ");
            Console.WriteLine(list.Count);
            Console.Write("Nodes: ");

            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }
            Console.Write("\n");
        }
<<<<<<< HEAD
        public int shortestPath(int fromNode, int toNode)
=======
        public void shortestPath(int fromNode, int toNode)
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
        {
            int i = toNode;
            string shortestPath = "";

            Dictionary<int, int> parent = BFS(fromNode);
<<<<<<< HEAD

=======
        
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
            if (parent.ContainsKey(i))
            {
                while (i != -1)
                {
                    shortestPath += (i + " -> ");
                    i = parent[i];
                }
                Console.Write(shortestPath);
            }
<<<<<<< HEAD
            else return -1;

            return 0;
=======
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
        }
        public Dictionary<int, int> BFS(int s)
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
                    foreach (int v in verteces[u])

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
                // printAL(frontier);
            }
            return parent;
        }
        public int getLength()
        {
            return verteces.Length;
        }
        public Dictionary<int, int> getParents()
        {
            return parent;
        }
        public Dictionary<int, int> getLevels()
        {
            return level;
        }

        public List<int> getNeighbours(int i)
        {
            return verteces[i];
        }
    }
}
