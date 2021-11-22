using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
  public class Graph
  {
    // add node
    public GraphNode AddNode(string value)
    {
      var newNode = new GraphNode
      {
        Value = value,
      };

      nodes.Add(newNode);

      return newNode;
    }

    // add edge

    // Private storage for our Nodes
    private readonly List<GraphNode> nodes = new List<GraphNode>();

    // Public should not be able to Add directly
    public IEnumerable<GraphNode> Nodes => nodes;

    // get neighbors

    // size
    public int Count => nodes.Count;
    // public int Count { get { return Nodes.Count();  } }
  }

  public class GraphNode
  {
    public string Value { get; set; }
  }
}
