// 23521 - Gustavo Cruz

using System;
using System.Collections;
using System.Collections.Generic;

// A hash table class that uses ArrayList as buckets
class BucketHashing<T> : IHashTable<T>
  where T : IRegistry<T>
{
    private int buckets = 131;
    private int bucketsInUse = 0;
    private ArrayList[] data;

    public BucketHashing()
    {
        data = new ArrayList[buckets];
        for (int i = 0; i < buckets; i++)
            data[i] = new ArrayList(1);
    }

    // Calulcates a hash for a key based on Horner's method
    public int Hash(string key)
    {
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash %= data.Length;
        if (hash < 0)
            hash += data.Length;
        return (int)hash;
    }

    public int ResizeTable(int buckets)
    {
        buckets = buckets * 2 + 1;
        while (!isPrime(buckets))
            buckets++;
        return buckets;
    }

    public void ReHash()
    {
        buckets = ResizeTable(buckets);
        bucketsInUse = 0;
        List<T> objects = Content();

        data = new ArrayList[buckets];
        for (int i = 0; i < buckets; i++)
            data[i] = new ArrayList(1);

        foreach (T obj in objects)
            Insert(obj);
    }

    public bool Insert(T item)
    {
        if (bucketsInUse >= buckets / 2)
            ReHash();

        int itemPosition;
        // Object already inserted in the bucket
        if (Exists(item, out itemPosition))
            return false;

        if (data[itemPosition].Count > 0)
        {
            foreach (T obj in data[itemPosition])
                // Prevents adding objects with the same key and different attributes in the same bucket
                if (obj.Key == item.Key)
                    return false;
        }
        bucketsInUse++;
        data[itemPosition].Add(item);
        return true;
    }

    public bool Remove(T item)
    {
        int itemPosition;
        if (!Exists(item, out itemPosition))
            return false;

        data[itemPosition].Remove(item);
        if (data[itemPosition].Count == 0)
            bucketsInUse--;
        return true;
    }

    // Checks whether an item exists in the hash table
    public bool Exists(T item, out int itemPosition)
    {
        itemPosition = Hash(item.Key);
        if (data[itemPosition].Count == 0)
            return false;
        return data[itemPosition].Contains(item);
    }

    // Get the content of each bucket that has at least one element
    public List<T> Content()
    {
        List<T> content = new List<T>();
        foreach (ArrayList bucket in data)
            if (bucket.Count > 0)
                foreach (T item in bucket)
                    content.Add(item);
        return content;
    }

    public bool isPrime(int size)
    {
        for (int i = 2; i < Math.Sqrt(size); i++)
            if (size % i == 0)
                return false;
        return true;
    }
}
