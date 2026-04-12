using System;
using System.Runtime.Versioning;

class Dijkstra
{
    public static void Run(string[] args)
    {
        FindBestPath();
    }

    /* 
    A->B, 4
    A->C, 2
    B->D, 2
    C->D, 1
    */

    /*
    Vertex
    A, B, C, D

    Edges
    A->B
    A->C
    B->D
    C->D

    Weight
    4
    2
    2
    1
    */

    public static void FindBestPath()
    {
        List<int> distanceList = new List<int> { };
        int edgeWeight = 0;

        List<string> vertices = ["A", "B", "C", "D"];

        // need to make a new dictionary that stores the best distance for each vertex, need to start at A

        Dictionary<string, List<List<string>>> graph = new()
        {
           { "A", [[vertices[1], "4"], [vertices[2], "2"]]},
            {"B", [[vertices[3], "1"], [vertices[3], "6"]]},
            {"C", [[vertices[3], "2"]]},
            {"D", []}
        };

        int smallest = 0;

        foreach (var item in graph["A"])
        {
            string name = item[0];
            edgeWeight = int.Parse(item[1]);
            distanceList.Add(edgeWeight);

            smallest = distanceList[0];

            for (int i = 0; i < distanceList.Count; i++)
            {
                if (distanceList[i] < smallest)
                {
                    smallest = distanceList[i];
                }
            }
        }
        Console.WriteLine(smallest);

        List<int> tempDistanceList = new List<int> { };
        // int tempSmallest = 0;      
        // int bestDistance = 0;
        int totalWeight = 0;
        totalWeight = totalWeight + smallest;

        foreach (var item in graph["B"])
        {
            string name = item[0];
            int tempEdgeWeight = int.Parse(item[1]);

            tempDistanceList.Add(tempEdgeWeight);
            // tempSmallest = tempDistanceList[0];

            // for (int i = 0; i < tempDistanceList.Count; i++)
            // {
            //     bestDistance = tempSmallest;
            // }
        }
        // bestDistance = totalWeight + tempSmallest;
        // Console.WriteLine(bestDistance);
    }
}