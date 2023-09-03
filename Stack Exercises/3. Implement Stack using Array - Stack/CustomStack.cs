using System;

public class CustomStack<T>
{
    private T[] _items;
    private int _top;
    private const int DefaultCapacity = 4;

    public CustomStack()
    {
        _items = new T[DefaultCapacity];
        _top = -1; // Stack is initially empty
    }

    public CustomStack(int initialCapacity)
    {
        if (initialCapacity < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Initial capacity must be at least 1.");
        }

        _items = new T[initialCapacity];
        _top = -1;
    }

    public int Count => _top + 1;

    public void Push(T item)
    {
        if (_top == _items.Length - 1)
        {
            // Stack is full, need to resize the array
            Array.Resize(ref _items, _items.Length * 2);
        }

        _top++;
        _items[_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = _items[_top];
        _top--;
        return item;
    }

    public T Peek()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return _items[_top];
    }
}