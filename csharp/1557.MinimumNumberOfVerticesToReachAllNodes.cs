// Given a directed acyclic graph, with n vertices numbered from 0 to n-1, and an array edges where edges[i] = [fromi, toi] represents a directed edge from node fromi to node toi.

// Find the smallest set of vertices from which all nodes in the graph are reachable. It's guaranteed that a unique solution exists.

// Notice that you can return the vertices in any order.

public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        
        var result = new List<int>();
        for (var i = 0; i < n; i++)
        {
            result.Add(i);
        }
        
        foreach(IList<int> edge in edges)
        {
            if (result.Contains(edge[1]))
                result.Remove(edge[1]);
        }

        return result;
    }
}