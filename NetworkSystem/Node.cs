using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkSystem
{
    //Node class- to present a node in the network system
    public class Node
    {
        // the node identifiers - key and label
        public int NodeKey { get; set; }
        public string NodeLabel { get; set; }

        // a dictionary to hold for each node object a list for out edgests
        // the key is the refferanced node and the value is the weight of the specific edgest
        public Dictionary<Node, int> OutEdgest { get; set; }
        public Node(int nodeKey, string nodeLabel)
        {
            NodeKey = nodeKey;
            NodeLabel = nodeLabel;
            OutEdgest = new Dictionary<Node, int>();
        }
    }
}
