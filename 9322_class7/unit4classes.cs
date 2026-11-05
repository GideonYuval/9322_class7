public class Node<T>
{
    private T value;
    private Node<T> next;

    //-----------------------------------
    //constructors
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }
    //-----------------------------------
    //getters
    public T GetValue()
    {
        return this.value;
    }
    public Node<T> GetNext()
    {
        return this.next;
    }
    //-----------------------------------
    //setters
    public void SetValue(T value)
    {
        this.value = value;
    }
    public void SetNext(Node<T> next)
    {
        this.next = next;
    }
    //-----------------------------------
    //return true if this.next is not null, else returns false
    public bool HasNext()
    {
        return (this.next != null);
    }
    //-----------------------------------
    //ToString
    public override string ToString()
    {
        return value + "," + next;
    }

}

public class Queue<T>
{
    private Node<T> first;
    private Node<T> last;

    //-----------------------------------
    //constructor
    public Queue()
    {
        this.first = null;
        this.last = null;
    }
    //-----------------------------------
    //adds element x to the end of the queue
    public void Insert(T x)
    {
        Node<T> temp = new Node<T>(x);
        if (first == null)
            first = temp;
        else
            last.SetNext(temp);
        last = temp;
    }
    //-----------------------------------
    //removes & returns the element from the head of the queue
    public T Remove()
    {
        if (IsEmpty())
            return default(T);
        T x = first.GetValue();
        first = first.GetNext();
        if (first == null)
            last = null;
        return x;
    }
    //-----------------------------------
    //returns the element from the head of the queue
    public T Head()
    {
        return first.GetValue();
    }
    //-----------------------------------
    //returns true if there are no elements in queue
    public bool IsEmpty()
    {
        return first == null;
    }
    //-------------------------------------
    //ToString
    public override string ToString()
    {
        if (this.IsEmpty())
            return "[]";
        string temp = first.ToString();
        return "QueueHead[" + temp.Substring(0, temp.Length - 1) + "]";
    }
}
public class Stack<T>
{
    private Node<T> head;

    //-----------------------------------
    //constructor
    public Stack()
    {
        this.head = null;
    }
    //-----------------------------------
    //adds element x to the top of the stack
    public void Push(T x)
    {
        Node<T> temp = new Node<T>(x);
        temp.SetNext(head);
        head = temp;
    }
    //-----------------------------------
    //removes & returns the element from the top of the stack
    public T Pop()
    {
        T x = head.GetValue();
        head = head.GetNext();
        return x;
    }
    //-----------------------------------
    //returns the element from the top of the stack
    public T Top()
    {
        return head.GetValue();
    }
    //-----------------------------------
    //returns true if there are no elements in stack
    public bool IsEmpty()
    {
        return head == null;
    }
    //-------------------------------------
    //ToString
    public override string ToString()
    {
        if (this.IsEmpty())
            return "[]";
        string temp = head.ToString();
        return "TOP <== " + temp.Substring(0, temp.Length - 1) + "]";
    }
}

public class IntNode
{
    private int value;
    private IntNode next;

    //-----------------------------------
    //constructors
    public IntNode(int value)
    {
        this.value = value;
        this.next = null;
    }
    public IntNode(int value, IntNode next)
    {
        this.value = value;
        this.next = next;
    }
    //-----------------------------------
    //getters
    public int GetValue()
    {
        return this.value;
    }
    public IntNode GetNext()
    {
        return this.next;
    }
    //-----------------------------------
    //setters
    public void SetValue(int value)
    {
        this.value = value;
    }
    public void SetNext(IntNode next)
    {
        this.next = next;
    }
    //-----------------------------------
    //return true if this.next is not null, else returns false
    public bool HasNext()
    {
        return (this.next != null);
    }
    //-----------------------------------
    //ToString
    public override string ToString()
    {
        return value + " --> " + next;
    }
}
public class Node2Dir<T>
{
    private T value;
    private Node2Dir<T> prev;
    private Node2Dir<T> next;

    //-----------------------------------
    //constructors
    public Node2Dir(T value)
    {
        this.value = value;
        this.prev = null;
        this.next = null;
    }
    public Node2Dir(Node2Dir<T> prev, T value, Node2Dir<T> next)
    {
        this.value = value;
        this.prev = prev;
        this.next = next;
    }
    //-----------------------------------
    //getters
    public T GetValue()
    {
        return value;
    }
    public Node2Dir<T> GetPrev()
    {
        return this.prev;
    }
    public Node2Dir<T> GetNext()
    {
        return this.next;
    }
    //-----------------------------------
    //setters
    public void SetValue(T value)
    {
        this.value = value;
    }
    public void SetPrev(Node2Dir<T> prev)
    {
        this.prev = prev;
    }

    public void SetNext(Node2Dir<T> next)
    {
        this.next = next;
    }
    //-----------------------------------
    //returns true if this.prev is not null, else returns false
    public bool HasPrev()
    {
        return (this.prev != null);
    }
    //returns true if this.next is not null, else returns false
    public bool HasNext()
    {
        return (this.next != null);
    }
    //-----------------------------------
    //ToString
    public override string ToString()
    {
        return value + " <--> " + next;
    }
}
public class BinNode<T>
{
    private T value;
    private BinNode<T> left;
    private BinNode<T> right;

    //-----------------------------------
    //constructors
    public BinNode(T value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
    public BinNode(BinNode<T> left, T value, BinNode<T> right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
    //-----------------------------------
    //getters
    public T GetValue()
    {
        return value;
    }
    public BinNode<T> GetLeft()
    {
        return this.left;
    }
    public BinNode<T> GetRight()
    {
        return this.right;
    }
    //-----------------------------------
    //setters
    public void SetValue(T value)
    {
        this.value = value;
    }
    public void SetLeft(BinNode<T> left)
    {
        this.left = left;
    }

    public void SetRight(BinNode<T> right)
    {
        this.right = right;
    }
    //-----------------------------------
    //returns true if this.left is not null, else returns false
    public bool HasLeft()
    {
        return (this.left != null);
    }
    //returns true if this.right is not null, else returns false
    public bool HasRight()
    {
        return (this.right != null);
    }
    //-----------------------------------
    //ToString
    public override string ToString()
    {
        return "(" + left + " " + value + " " + right + ")";
    }
}

