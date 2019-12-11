using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    public static class LinkedListExtentions
    {
        public static LinkedListNode<T> NextNode<T>(this LinkedListNode<T> node)
        {
            return node.Next ?? node.List.First;
        }

        public static LinkedListNode<T> PreviousNode<T>(this LinkedListNode<T> node)
        {
            return node.Previous ?? node.List.Last;
        }
    }
}
