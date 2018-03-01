﻿////====================================================================================================================
//// IMPLEMENTING 3 STACKS USING ONE ARRAY
//// WOULD CONSIDER MAKING THIS ITS OWN CLASS WITH CTOR, BUT THIS STRUCTURE ACCOMPLISHED MY PURPOSE
////
//// Assuming a fixed size array of a size that is equally
//// divisible by 3 and equal size stacks


////Array to house the stacks, using ints in this case
//int stackSize = 100;
//int[] stackKeeper = new int[stackSize * 3];
//int[] stackPointer = { -1, -1, -1 };

////PUSH
////Adds a value to the top position of the stack indicated
//void push(int value, int stackNumber)
//{
//    if (stackPointer[stackNumber] >= stackSize)
//    {
//        Console.WriteLine("Stack is at capacity, new item cannot be added.");
//        return;
//    }

//    stackPointer[stackNumber] += 1;
//    stackKeeper[getKeeperIndex(stackNumber)] = value;

//}

////pop
//int pop(int stackNum)
//{
//    if (stackPointer[stackNum] < 0)
//    {
//        throw new Exception(message: "Trying to pop and empty stack");
//    }

//    //get the value of the number being returned
//    int value = stackKeeper[getKeeperIndex(stackNum)];

//    //reset the index returned above, if needed
//    //stackKeeper[getKeeperIndex(stackNum)] = 0;

//    //decrement the stack index
//    stackPointer[stackNum]--;

//    return value;
//}

//int peek(int stackNum)
//{
//    return stackKeeper[getKeeperIndex(stackNum)];
//}

////takes the stackNumber and returns the index in the array container
//int getKeeperIndex(int stackNum)
//{
//    return stackSize * stackNum + stackPointer[stackNum];
//}

////count
//int count(int stackNum)
//{
//    return stackPointer[stackNum] + 1;
//}

////isEmpty
//bool isEmpty(int stackNum)
//{
//    return stackPointer[stackNum] == -1;
//}



////====================================================================================================================
//// IMPLEMENTING A STACK THAT KEEPS TRACK OF THE MINIMUM VALUE IN THE STACK
//// ASSUMING ITS OKAY TO USE THE .NET STACK CLASS TO KEEP TRACK OF THE MINIMUM VALUES.
//class Program
//{
//    static void Main(string[] args)
//    {
//        MyStack stack1 = new MyStack(12);
//        stack1.printStack();
//        stack1.push(14);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.pop();
//        stack1.pop();
//        stack1.min();

//        stack1.push(14);
//        stack1.push(24);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(11);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(2);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(30);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(49);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(37);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(48);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(7);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(153);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(88);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(2);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(1);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();
//        stack1.pop();
//        stack1.push(1);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        stack1.pop();
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        stack1.pop();
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        Console.ReadKey();

//    }
//}

//class MyStack
//{
//    private int[] stackArray;
//    private Stack<int> minStack;
//    private int stackIndex;

//    public MyStack(int size)
//    {
//        stackArray = new int[size];
//        minStack = new Stack<int>();
//        stackIndex = -1;
//    }

//    public void push(int value)
//    {
//        if (stackIndex == -1) //empty stack
//        {
//            minStack.Push(value); // any value added will be a minimum
//        }
//        else if (stackIndex == (stackArray.Length - 1))
//        {
//            Console.WriteLine("Stack is at capacity, item could not be added.");
//            return;
//        }
//        else if (value <= minStack.Peek()) // incoming value is less than or equal to top value on the minStack
//        {
//            minStack.Push(value);  //added value is the new minimum
//        }

//        // Incoming value greater than the top value on the minStack.
//        // Nothing needs to be done with minStack. Only add incoming value to the stackArray

//        stackArray[++stackIndex] = value;

//    }

//    public int pop()
//    {
//        //deal with popping from empty stack
//        if (stackIndex == -1)
//        {
//            Console.WriteLine("Trying to pop from an empty stack");
//            return Int32.MinValue;
//        }

//        int returnVal = stackArray[stackIndex];

//        // Compare value being popped with the top element on the minStack.
//        if (returnVal == minStack.Peek())
//        {
//            minStack.Pop();  //remove top element from minstack
//        }

//        //decrement stack index and return the popped value
//        stackIndex--;

//        return returnVal;
//    }

//    public int min()
//    {
//        try
//        {
//            return minStack.Peek();
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Trying to peek on an empty stack");
//            return Int32.MaxValue;
//        }
//    }

//    public int count()
//    {
//        return stackIndex + 1;
//    }

//    public void printStack()
//    {
//        if (stackIndex == -1)
//        {
//            Console.WriteLine("Stack is empty, nothing to print!\n");
//            return;
//        }

//        Console.WriteLine("The stack currently contains:\n");
//        for (int i = stackIndex; i >= 0; i--)
//        {
//            Console.WriteLine(stackArray[i]);
//        }
//    }

//}



////====================================================================================================================
////IMPLEMENTATION OF A SET OF STACKS
////IF A STACK N VALUES BECOMES FULL ANOTHER STACK OF N IS CREATED
////THIS INCLUDES AN ADDITIONAL COCMPLEXITY WITH A popAt(index) FUNCTION THAT WILL POP OF THE TOP ITEM OF THE index ITEM IN THE SET OF STACKS
////AS PART OF THE popAt(index) FUNCTION, A ROLLOVER OCCURS FROM THE TOP OF THE NEXT STACK THE BOTTOM OF THE CURRENT STACK.  THIS KEEPS THE
////NUMBER OF FULL STACKS TO THE FRONT OF THE SET OF STACKS

//class Program
//{
//    static void Main(string[] args)
//    {
//        SetOfStacks ss = new SetOfStacks(10);

//        for (int i = 0; i < 40; i++)
//        {
//            ss.push(i * 2);
//        }

//        //for (int i = 0; i < 40; i++)
//        //{
//        //    ss.pop();
//        //}

//        ss.popAt(0);

//        ss.pop();

//        Console.ReadKey();
//    }

//    class SetOfStacks
//    {
//        List<MyStack> master;
//        int stackSize;
//        int masterIndex;

//        public SetOfStacks(int stackSize)
//        {
//            master = new List<MyStack>(7);
//            this.stackSize = stackSize;
//            masterIndex = 0;
//            master.Add(new MyStack(stackSize));
//        }

//        public int popAt(int targetIndex)
//        {
//            if (master[targetIndex].Count != 10 || targetIndex == masterIndex)
//            {
//                return master[targetIndex].pop();
//            }

//            int bottomVal = popAt(targetIndex + 1);
//            int topVal = master[targetIndex].pop();

//            MyStack temp = new MyStack(stackSize);

//            while (!master[targetIndex].isEmpty())
//            {
//                temp.push(master[targetIndex].pop());
//            }

//            master[targetIndex].push(bottomVal);

//            while (!temp.isEmpty())
//            {
//                master[targetIndex].push(temp.pop());
//            }

//            return topVal;
//        }

//        public void push(int value)
//        {
//            //check if the current stack is full
//            if (master[masterIndex].Count == stackSize)
//            {
//                //no room on current stack, create a new one at the next master index
//                master.Add(new MyStack(stackSize));
//                masterIndex++;
//            }
//            master[masterIndex].push(value);
//        }

//        public int pop()
//        {
//            if (master[masterIndex].isEmpty())
//            {
//                Console.WriteLine("Error thrown - Somthing bad happened. Trying to pop from an empty stack.");
//                return Int32.MinValue;
//            }

//            int value = master[masterIndex].pop();

//            if (master[masterIndex].isEmpty())
//            {
//                masterIndex--;
//            }

//            return value;
//        }
//    }

//    public class MyStack
//    {
//        private int[] stack { get; set; }
//        private int index;
//        private int maxSize;
//        public int Count { get; private set; } = 0;

//        public MyStack(int size)
//        {
//            maxSize = size;
//            stack = new int[maxSize];
//            index = 0;
//        }

//        public void push(int value)
//        {
//            if (index == maxSize)
//            {
//                Console.WriteLine("Error - Stack is full, item was not pushed.");
//            }

//            stack[index++] = value;
//            Count++;
//        }

//        public int pop()
//        {
//            if (isEmpty())
//            {
//                Console.WriteLine("Error - Trying to pop from an empty stack.");
//                return Int32.MinValue;
//            }

//            int retVal = stack[--index];
//            stack[index] = 0;
//            Count--;

//            return retVal;
//        }

//        public bool isEmpty()
//        {
//            return Count == 0;
//        }
//    }
//}