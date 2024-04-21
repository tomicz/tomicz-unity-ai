using Tomicz.AI.Tree;

namespace Tomicz.AI.Nodes
{
    public class RootNode : Node
    {
        public RootNode(Node parentNode) : base(parentNode){}

        public override NodeStatus Tick()
        {
            return NodeStatus.Success;
        }
    }
}
