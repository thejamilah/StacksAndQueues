using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues.Classes
{
    public class Stack
    {
        public class Node Top { get; set; }

    public Stack(Node node)
    {
        Top = node;
    }


}

//Peek
public Node Peek()
{
    return Top;
}

//Pop
public Node Pop()
{
    Node temp = Top.Next;
    Top = Top.Next;
    temp.Next = null;
    return temp;
}

//Push
public void Push(Node node)
{
    node.Next = Top;
    Top = node;
}

}
