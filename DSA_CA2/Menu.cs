﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CA2
{
    class Menu
    {
        private static string instructions = "Please Enter:\n[1] Enter Graph Data\n[2] Shortest Path\n[3] Print List\n[0] Exit";
        private AdjacencyList adjList;

<<<<<<< HEAD
        public Menu(AdjacencyList aList)
        {
            this.adjList = aList;
        }

        public void printList()
        {
            for (int i = 0; i < adjList.getLength(); i++)
            {
                if (adjList.getNeighbours(i).Count == 0)
=======
        public static void printList(AdjacencyList adj)
        {
            for (int i = 0; i < adj.getLength(); i++)
            {
                if (adj.getNeighbours(i).Count == 0)
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
                {
                    continue;
                }

                String neighbours = "";
<<<<<<< HEAD
                foreach (int j in adjList.getNeighbours(i))
                {
                    neighbours += j + " ";
                }
                Console.WriteLine("Node " + (i + 1) + "\nNeighbours: " + neighbours + "\n\n");
            }
        }

        public void menuLoop()
=======
                foreach (int j in adj.getNeighbours(i))
                {
                    neighbours += j + " ";
                }
                Console.WriteLine("Node " + (i + 1) + ":\n" + neighbours + "\n\n");
            }
        }

        public static void menuLoop()
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
        {
            int choice = -1;

            while(choice != 0)
            {
                Console.WriteLine(instructions);
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 1:
<<<<<<< HEAD
                        Console.WriteLine("createAdjacencyList();");
                        break;
                    case 2:
                        this.launchShortestPath();
                        break;
                    case 3:
                        this.printList();
=======
                        Console.WriteLine("createAdjList();");
                        break;
                    case 2:
                        Console.WriteLine("shortestPath();");
                        break;
                    case 3:
                        Console.WriteLine("PrintList();");
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            }
        }

<<<<<<< HEAD
        // Reads nodes, checks error code and handles user request for shortest path
        public void launchShortestPath()
        {
            int check;
            do
            {
                Console.WriteLine("Which node would like to start from? ");
                int startNode = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nWhich node would you like the shortest path to? ");
                int endNode = Int32.Parse(Console.ReadLine());

                check = adjList.shortestPath(startNode, endNode);

                if (check == -1)
                {
                    Console.WriteLine(" Node(s) not found, try again.");
                }

            } while (check == -1);
=======

        public static void launchShortestPath()
        {
    

>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
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

<<<<<<< HEAD
            Menu menu = new Menu(adj);
            menu.menuLoop();
            menu.printList();

=======
            Menu.printList(adj);

            Menu.menuLoop();

            
>>>>>>> 950226baada412decde77bd5e71d8d986835f47a
        }
    }
}
