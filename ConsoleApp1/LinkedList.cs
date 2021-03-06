﻿
    //// GENERATE A SINGLY LINKED LIST 
    //{
    //    LinkedList<int> list = new LinkedList<int>();
    //    list.AddFirst(18);
    //    list.AddLast(256);
    //    list.AddLast(96);
    //    list.AddLast(63);
    //    list.AddLast(45);
    //    list.AddLast(135);
    //    list.AddLast(204);
    //    list.AddLast(45);
    //    list.AddLast(45);
    //}

    ////DISPLAY STARTING LIST
    //Console.WriteLine("Here is the Linked list we're starting with:");
    //printList(list);
    //Console.WriteLine("____________________________________________");

    ////====================================================================================================================

    ////navigate to the node you want to remove. "one" in this instance
    //LinkedListNode<string> target = list.First;
    //target = target.Next;  //second node
    //target = target.Next;  //seconde node
    //Console.WriteLine("\nThe target node holds the value: {0}", target.Value);
    //Console.WriteLine("____________________________________________");

    ////Remove the node (method call)
    //removeNode(target);

    ////display the list following the removal call
    //Console.WriteLine("\nHere is the Linked list we're starting with:");
    //printList(list);

    ////remove a singly linked list node where you only have access to the node passed into the method
    ////algorithm seems correct but doesn't exactly do what it's supposed to
    //public static void removeNode(LinkedListNode<string> target)
    //{
    //    LinkedListNode<string> next = target.Next;

    //    while (next != null)
    //    {
    //        if (next.Next != null)
    //        {
    //            target.Value = next.Value;
    //            target = next;
    //            next = next.Next;
    //        }
    //        else
    //        {
    //            next.Value = null;
    //        }
    //    }
    //}

    ////====================================================================================================================

    //static void printList(LinkedList<int> list)
    //{
    //    LinkedListNode<int> t = list.First;
    //    while (t != null)
    //    {
    //        Console.WriteLine(t.Value);
    //        t = t.Next;
    //    }
    //}

    ////====================================================================================================================

    ////===================TEST 1 REMOVE USING RECURSION================================
    //Console.WriteLine("\nFind the 3rd from last node using recursion: {0}", findK(list.First, 3 ).Value);
    //Console.WriteLine("\nHere is what the list looks like now:");
    //printList(list);
    //Console.WriteLine("____________________________________________");


    ////===================TEST 2 REMOVE USING ITERATION================================
    //Console.WriteLine("\nFind the 5th from last node using iteration: {0}", findKthNode(list, 7).Value);
    ////todo implement iterative function that returns the kth from last value (assume a singly linked list)

    //Console.WriteLine("\nHere is what this list looks like now:");
    //printList(list);

    ////Iterative method for finding the Kth to last node in a singly linked list
    //static LinkedListNode<string> findKthNode(LinkedList<string> list, int k)
    //{
    //    if (list.Count < k)
    //    {
    //        //not enough nodes in list to for k to exist
    //        return null;
    //    }

    //    //set both tracking nodes to the head of the list
    //    LinkedListNode<string> runner = list.First;
    //    LinkedListNode<string> trailer = list.First;

    //    //send the runner k nodes ahead of the trailer
    //    for (int i = 0; i < k - 1; i++)
    //    {
    //        runner = runner.Next;
    //    }

    //    //iterate throught the list until last node is reached incrementing both tracking nodes
    //    while (runner.Next != null)
    //    {
    //        runner = runner.Next;
    //        trailer = trailer.Next;
    //    }

    //    return trailer;
    //}


    ////Recursive method for finding the Kth to last node in a singly linked list
    //static LinkedListNode<string> findK(LinkedListNode<string> t, int k)
    //{
    //    if (t == null)
    //    {
    //        return null;
    //    }

    //    LinkedListNode<string> node = findK(t.Next, k);
    //    count++;
    //    if (count == k)
    //    {
    //        return t;
    //    }

    //    return node;
    //}

    ////====================================================================================================================

    ////takes a value x
    ////moves values less than x to the front of the list - by front it is meant that the nodes are ahead of x in value, not necessarily to the head of the list
    ////move values less than x to the back of the list - by back it is meant that the nodes are behind of x in value, not necessarily to the rear of the list

    ////CODE FROM MAIN TO CALL THE METHOD
    //list = listPartition(list.First, 45);

    //LinkedList<int> listPartition(LinkedListNode<int> source, int x)
    //{
    //    int equalCount = 0;
    //    LinkedList<int> destination = new LinkedList<int>();

    //    if (source == null || source.Next == null)
    //    {
    //        Console.WriteLine("\nThe list does not have enought nodes to sort");
    //        destination.AddFirst(source);
    //        return destination;
    //    }

    //    while (source != null)
    //    {
    //        if (source.Value > x)
    //        {
    //            destination.AddLast(new LinkedListNode<int>(source.Value));
    //        }
    //        else if (source.Value < x)
    //        {
    //            destination.AddFirst(new LinkedListNode<int>(source.Value));
    //        }
    //        else
    //        {
    //            equalCount++;
    //        }

    //        source = source.Next;
    //    }

    //    //find a location to inject the equal values (if there are any)

    //    if (equalCount > 0)
    //    {
    //        LinkedListNode<int> temp = destination.First;
    //        //iterate through list and insert before or after?

    //        //find the insertion point
    //        while (temp.Value < x)
    //        {
    //            temp = temp.Next;
    //        }

    //        while (equalCount > 0)
    //        {
    //            destination.AddBefore(temp, x);
    //            equalCount--;
    //        }
    //    }


    //    return destination;
    //}


    ////====================================================================================================================

    ////PRINTS A INTEGER BASED LINKED LIST
    //static void printList(LinkedList<int> list)
    //{
    //    LinkedListNode<int> t = list.First;
    //    while (t != null)
    //    {
    //        Console.WriteLine(t.Value);
    //        t = t.Next;
    //    }
    //}

