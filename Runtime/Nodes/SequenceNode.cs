using Tomicz.AI.BehaviourTree;

namespace Tomicz.AI.Nodes
{
    public class SequenceNode : Node 
    {
        public SequenceNode(Node parentNode) : base(parentNode) {}

        public override NodeStatus Tick()
        {
            foreach(Node node in _children)
            {
                switch(node.Tick())
                {
                    case NodeStatus.Failure:
                        continue;
                    case NodeStatus.Success:
                        _nodeStatus = NodeStatus.Success;
                        return _nodeStatus;
                    case NodeStatus.Runnning:
                        _nodeStatus = NodeStatus.Runnning;
                        return NodeStatus.Runnning;
                    default:
                        continue;
                }
            }
            return _nodeStatus;
        }
    }
}
