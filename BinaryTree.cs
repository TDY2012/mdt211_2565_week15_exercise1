class BinaryTree<T> where T : struct
{
    private Node<T> root = null;
    private int length = 0;

    public void AddLeft(int index, T value)
    {
        Node<T> node = new Node<T>(value);
        if(index == -1)
        {
            node.SetLeft(this.root);
            this.root = node;
        }
        else
        {
            Node<T> ptr = this.GetNode(index);
            node.SetLeft(ptr.Left());
            ptr.SetLeft(node);
        }
        this.length++;
    }

    public void AddRight(int index, T value)
    {
        Node<T> node = new Node<T>(value);
        if(index == -1)
        {
            node.SetLeft(this.root);
            this.root = node;
        }
        else
        {
            Node<T> ptr = this.GetNode(index);
            node.SetRight(ptr.Right());
            ptr.SetRight(node);
        }
        this.length++;
    }

    public void Remove(int index)
    {
        if(index == 0)
        {
            Node<T> ptr = this.root;
            this.root = ptr.Left();
            if(this.root.Right() != null)
            {
                this.root.SetLeft(this.root.Right());
                this.root.SetRight(null);
            }
        }
        else
        {
            Node<T> previousPtr = this.GetNode(index-1);
            if(previousPtr.Left() != null)
            {
                Node<T> ptr = previousPtr.Left();

                if(ptr.Right() != null)
                {
                    previousPtr.SetLeft(ptr.Left());
                    ptr.Right().SetRight(ptr.Right());
                }
                else
                {
                    previousPtr.SetLeft(ptr.Right());
                }
            }
            else
            {
                Node<T> ptr = previousPtr.Right();

                if(ptr.Left() != null)
                {
                    previousPtr.SetRight(ptr.Left());
                    ptr.Left().SetRight(ptr.Right());
                }
                else
                {
                    previousPtr.SetRight(ptr.Right());
                }
            }
        }
        this.length--;
    }

    public int GetLength()
    {
        return this.length;
    }

    public T Get(int index)
    {
        Node<T> ptr = this.GetNode(index);
        return ptr.GetValue();
    }

    private Node<T> GetNode(int index)
    {
        int traverseStep = index;
        return this.Traverse(this.root, ref traverseStep);
    }

    private Node<T> Traverse(Node<T> currentNode, ref int traverseStep)
    {
        Node<T> ptr = currentNode;

        if(traverseStep > 0 && currentNode.Left() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentNode.Left(), ref traverseStep);
        }

        if(traverseStep > 0 && currentNode.Right() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentNode.Right(), ref traverseStep);
        }

        return ptr;
    }
}