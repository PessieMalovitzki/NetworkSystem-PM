using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkSystem
{
    //Graph calss as a data structor to hold the network
    public static class Graph
    {
        
        static public HashSet<Node> _NodesList = new HashSet<Node>();
        
        //Add a new node to the graph
        public static void AddNode(int key, string label)
        {
            if(key > 0 && !string.IsNullOrEmpty(label))
            {
                Node node = new Node(key, label);
                if(!_NodesList.Contains(node))
                _NodesList.Add(new Node(key, label));
                
            }
        }
        //Add a new adgests -
        //Reference to a new node from the source node linked list (calculate wighted edgests)
        public static void AddEdgest(Node source, Node target)
        {
            if (!source.OutEdgest.ContainsKey(target))
                source.OutEdgest.Add(target, 1);
            else
                source.OutEdgest[target] += 1;
        }

        //Function that serches a node object by key
        public static Node findNodeByKey(int sourceKey)
        {
            return _NodesList.Where(x=>x.NodeKey==sourceKey).FirstOrDefault();
        }

        //Function that serches a node object by label
        public static Node findNodeByLabel(string label)
        {
            return _NodesList.Where(x => x.NodeLabel == label).FirstOrDefault();
        }
    }
   
}
