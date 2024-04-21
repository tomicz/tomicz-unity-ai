namespace Tomicz.AI.BehaviourTree
{
    public abstract class Tree
    {
        public readonly Node RootNode;

        public Tree(Node rootNode)
        {
            RootNode = rootNode;
        }
    }
}