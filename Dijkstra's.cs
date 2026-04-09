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

        // var distance = 0;
        // var nextVertex = 0;
        // var currenTVertex = 0;

        List<string> vertices = ["A", "B", "C", "D"];

        List<List<string>> A = [[vertices[1], "4"], [vertices[2], "2"]];
        List<List<string>> B = [[vertices[3], "1"]];
        List<List<string>> C = [[vertices[3], "2"]];


        for (int i = 0; i < A.Count; i++)
        {
            int.TryParse(A[i][1], out int weight);
            Console.WriteLine(A[i][1]);
            

        }

        List<string> bestPath = new List<string> { };
    }
}