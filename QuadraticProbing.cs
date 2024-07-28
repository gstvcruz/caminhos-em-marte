// 23521 - Gustavo Cruz

using System;
using System.Collections.Generic;

// A hash table that uses quadratic probing for hashing
public class QuadraticProbing<T> : IHashTable<T>
    where T : IRegistry<T>
{
    private int physicalSize = 131;
    private int logicalSize = 0;
    private T[] data;

    public QuadraticProbing()
    {
        data = new T[physicalSize];
    }

    /*
     * Determines the hash of a key based on quadratic probing.
     * 
     * If the hash table is (a) more than half full or (b) the position corresponding to
     * the initial hash value is empty, immediately returns the initial hash value, else
     * keep looking for an empty spot.
    */
    public int Hash(string key)
    {
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash %= physicalSize;
        if (hash < 0)
            hash += physicalSize;
        int initialPosition = (int)hash;

        if ((data[initialPosition] == null) || (logicalSize >= physicalSize / 2))
            return initialPosition;

        // A collision occurred
        int currentPosition = initialPosition;
        int collisions = 1; 
        while (data[currentPosition] != null)
        {
            // Object already added
            if (data[currentPosition].Key == key)
                return currentPosition;
            
            currentPosition = (currentPosition + (int)Math.Pow(collisions++, 2)) % physicalSize;
        } 
        return currentPosition;
    }

    public bool Insert(T item)
	{
        // If hash table is more than half full, rehash it to proceed with insertion
        if (logicalSize >= physicalSize / 2)
            ReHash();

        if (Exists(item, out int itemPosition))
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
}
