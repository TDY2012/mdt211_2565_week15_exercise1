class Node<T> where T : struct
{
    private T value;
    private Node<T> left = null;
    private Node<T> right = null;

    public Node(T value)
    {
        this.SetValue(value);
    }

    public void SetLeft(Node<T> left)
    {
        this.left = left;
    }

    public void SetRight(Node<T> right)
    {
        this.right = right;
    }

    public Node<T> Left()
    {
        return this.left;
    }

    public Node<T> Right()
    {
        return this.right;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }
}