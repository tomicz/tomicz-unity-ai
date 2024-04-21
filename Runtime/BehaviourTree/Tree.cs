namespace Tomicz.AI.BehaviourTree
{
    public abstract class Tree
    {
        public readonly Node RootNode;

        public Tree(Node rootNode)
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