// 23521 - Gustavo Cruz

using System;
using System.Collections.Generic;

// A hash table class that uses double hashing for hashing
public class DoubleHashing<T> : IHashTable<T>
    where T : IRegistry<T>
{
    private int physicalSize = 131;
    private int logicalSize = 0;
    private T[] data;

    public DoubleHashing()
    {
        data = new T[physicalSize];
    }

    /*
     * +------------------------------------------------------------+
     * | Determines the hash value of a key based on double hashing |
     * +------------------------------------------------------------+
     * 
     * Multiple succesive hashes are performed on a previous calculated hash value
     * untill an empty position is found in the hash table.
    */
    public int Hash(string key)
    {
        // Calculates the initial hash value
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash %= physicalSize;
        if (hash < 0)
            hash += physicalSize;
        int initialPosition = (int)hash;

        int currentPosition = initialPosition;
        int collisions = 0;
        // Inspects each position of the hash table
        while (data[currentPosition] != null)
        {
            // Found an object with the same key
            if (data[currentPosition].Key == key)
                return currentPosition;
            // Keep looking for an empty spot
            currentPosition = currentPosition + collisions * (13 - currentPosition % 13);
            collisions++;
        }
        return currentPosition;
    }

    public int ResizeTable(int physicalSize)
    {
        physicalSize = physicalSize * 2 + 1;
        while (!isPrime(physicalSize))
            physicalSize++;
        return physicalSize;
    }

    public void ReHash()
    {
        physicalSize = ResizeTable(physicalSize);
        logicalSize = 0;
        List<T> objects = Content();

        data = new T[physicalSize];
        foreach (T obj in objects)
            Insert(obj);
    }

    public bool Insert(T item)
    {
        // If hash table is more than half full, rehash it to proceed with insertion
        if (logicalSize >= physicalSize / 2)
            ReHash();

        int itemPosition;
        // Object already inserted in the hash table
        if (Exists(item, out itemPosition))
            return false;

        if (data[itemPosition] != null)
        {
            // Prevents overriding between objects with the same key
            if (data[itemPosition].Key == item.Key)
                return false;
            // Prevents overriding a different object
            if (data[itemPosition].Key != item.Key)
                return false;
        }
        data[itemPosition] = item;
        logicalSize++;
        return true;
    }

    public bool Remove(T item)
    {
        int itemPosition;
        if (Exists(item, out itemPosition))
        {
            data[itemPosition] = default;
            logicalSize--;
            return true;
        }
        return false;
    }

    public bool Exists(T item, out int itemPosition)
    {
        itemPosition = Hash(item.Key);
        if (data[itemPosition] == null)
            return false;
        return data[itemPosition].Equals(item);
    }

    public List<T> Content()
    {
        List<T> content = new List<T>();
        foreach (T item in data)
            if (item != null)
                content.Add(item);
        return content;
    }

    public bool isPrime(int physicalSize)
    {
        for (int i = 2; i < Math.Sqrt(physicalSize); i++)
            if (physicalSize % i == 0)
                return false;
        return true;
    }
}
