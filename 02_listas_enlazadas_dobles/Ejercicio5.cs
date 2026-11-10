using System;
using System.Collections.Generic;

public class Node<T>
{
        public T Key;
    public Node<T> Prev;
    public Node<T> Next;

    public Node(T key)
    {
        Key = key;
        Prev = null;
        Next = null;
    }
}

public class LRUCache<T>
{
    private readonly int _capacity;
    private readonly Dictionary<T, Node<T>> _map;
    private Node<T> _head;
    private Node<T> _tail;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _map = new Dictionary<T, Node<T>>();
        _head = null;
        _tail = null;
    }

    public void Insert(T key)
    {
                if (_map.ContainsKey(key))
        {
            Node<T> node = _map[key];
            node.Key = key;
            RemoveNode(node);
            AddToHead(node);
        } else
        {
            if (_map.Count >= _capacity)
            {
                if (_tail != null)
                {
                    Console.Write($"Desaloja {_tail.Key} → ");
                    _map.Remove(_tail.Key);
                    RemoveNode(_tail);
                }
            }
            Node<T> newNode = new Node<T>(key);
            AddToHead(newNode);
            _map[key] = newNode;
        }
    }

    public void Access(T key)
    {
        if (_map.ContainsKey(key))
        {
                        Node<T> node = _map[key];
            RemoveNode(node);
            AddToHead(node);
        }
    }

    private void AddToHead(Node<T> node)
    {
        node.Next = _head;
        node.Prev = null;
        if (_head != null)
        {
            _head.Prev = node;
        }
        _head = node;
        if (_tail == null)
        {
            _tail = node;
        }
    }

    private void RemoveNode(Node<T> node)
    {
        if (node.Prev != null)
        {
            node.Prev.Next = node.Next;
        } else
        {
            _head = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Prev = node.Prev;
        } else
        {
            _tail = node.Prev;
        }
    }

    public void PrintCache()
    {
        var list = new List<T>();
        Node<T> current = _head;
        while (current != null)
        {
            list.Add(current.Key);
            current = current.Next;
        }
        Console.WriteLine($"[{string.Join(" ⇄ ", list)}]");
    }
}

public class Program
{
    public static void Main()
    {
        LRUCache<string> cache = new LRUCache<string>(3);

        //  Insertar A, B, C
        cache.Insert("A");
        cache.Insert("B");
        cache.Insert("C");
        Console.Write("1. Insertar A, B, C → ");
        cache.PrintCache();

        //  Consultar A
        cache.Access("A");
        Console.Write("2. Consultar A → ");
        cache.PrintCache();

        // Insertar D
        Console.Write("3. Insertar D → ");
        cache.Insert("D");
        cache.PrintCache();
    }
}