namespace Tomicz.AI.Tree
{
    public abstract class BehaviourTree
    {
        public readonly Node RootNode;

        public BehaviourTree(Node rootNode)
        {
            RootNode = rootNode;
        }

        public abstract Node Init();

        public void Tick()
        {
            if(RootNode != null)
            {
                RootNode.Tick();
            }
        }
    }
}