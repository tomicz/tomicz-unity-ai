using System.Collections.Generic;

namespace Tomicz.AI.BehaviourTree
{
    public abstract class Node 
    {
        public Node ParentNode {get; private set;}

        private Dictionary<string, object> _data = new Dictionary<string, object>();

        protected List<Node> _children = new List<Node>();
        protected NodeStatus _nodeStatus;

        public Node(Node parentNode)
        {
            ParentNode = parentNode;
            
            foreach(var node in _children)
            {
                node.ParentNode = this;
                _children.Add(node);
            }
        }

        public abstract NodeStatus Tick();
    }
}
