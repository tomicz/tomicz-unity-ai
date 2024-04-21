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

        public void SetData(string key, object value)
        {
            _data[key] = value;
        }

        public object GetData(string key)
        {
            object value = null;

            if(_data.TryGetValue(key, out value))
            {
                return value;
            }

            Node node = ParentNode;

            while(node != null)
            {
                value = node.GetData(key);

                if(value != null)
                {
                    return value;
                }

                node = node.ParentNode;
            }

            return null;
        }

        public bool ClearData(string key)
        {
            if(_data.ContainsKey(key)) 
            {
                    _data.Remove(key);
                    return true;
            }

            Node node = ParentNode;

            while(node != null)
            {
                bool isCleared = node.ClearData(key);

                if(isCleared)
                {
                    return true;
                }

                node = node.ParentNode;
            }

            return false;
        }
    }
}
