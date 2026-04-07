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
        int bestWeightOverall = 0;
        int weightSoFar = 0;
        List<string> vertices = ["A", "B", "C", "D"];
        List<List<string>> edges = [["A", "0"], ["B", "4"], ["C", "2"], ["D", "2"], ["D", "1"]];
        List<string> bestPath = new List<string> { };
        








    }
}