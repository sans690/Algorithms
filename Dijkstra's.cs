using System;

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

        // List<string> currentVertex = A[0];
        // string currentVertexWeightString = currentVertex[1];
        // int.TryParse(currentVertexWeightString, out int currentVertexWeight);
        // int currentVertexDistance = 0;
        // currentVertexDistance += currentVertexWeight;


        // List<string> neighborVertex = A[1];
        // string neighborVertexWeightString = neighborVertex[1];
        // int.TryParse(neighborVertexWeightString, out int neighborVertexWeight);
        // int neighborVertexDistance = 0;
        // neighborVertexDistance += neighborVertexWeight;


        Dictionary<string, List<List<string>>> graph = new()
        {
           { "A", [[vertices[1], "4"], [vertices[2], "2"]]},
            {"B", [[vertices[3], "1"]]},
            {"C", [[vertices[3], "2"]]},
            {"D", []}
        };

        foreach (var item in graph["A"])
        {
            string name = item[0];
            edgeWeight = int.Parse(item[1]);
            distanceList.Add(edgeWeight);

            Console.WriteLine(distanceList);

            int smallest = 0;
            for (int i = 0; i < graph["A"].Count; i++)

            {
            }


        }


    }
}