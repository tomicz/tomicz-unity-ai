namespace Tomicz.AI.BehaviourTree
{
    public class Node 
    {
       public readonly Node Right;
       public readonly Node Left; 

       public Node(Node rightNode, Node leftNode)
       {
            Right = rightNode;
            Left = leftNode;
       }
    }
}
