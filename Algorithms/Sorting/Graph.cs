namespace Sorting_and_Searching_Algorithms.Algorithms.Sorting
{
    internal partial class SelectionSort
    {
        public class Graph
        {
            private int V; // Number of vertices
            private List<int>[] adj; // Adjacency list

            public Graph(int vertices)
            {
                V = vertices;
                adj = new List<int>[V];
                for (int i = 0; i < V; i++)
                {
                    adj[i] = new List<int>();
                }
            }

            public void AddEdge(int v, int w)
            {
                adj[v].Add(w);
            }

            public void DFS(int startVertex)
            {
                bool[] visited = new bool[V]; // Track visited vertices

                Stack<int> stack = new Stack<int>();
                stack.Push(startVertex);

                while (stack.Count > 0)
                {
                    int v = stack.Pop();

                    if (!visited[v])
                    {
                        visited[v] = true;
                        Console.Write(v + " ");

                        foreach (int neighbor in adj[v])
                        {
                            if (!visited[neighbor])
                            {
                                stack.Push(neighbor);
                            }
                        }
                    }
                }
            }
        }
    }
}
