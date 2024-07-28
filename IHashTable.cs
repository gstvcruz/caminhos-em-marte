// 23521 - Gustavo Cruz

using System.Collections.Generic;

public interface IHashTable<T>
  where T : IRegistry<T>
{
    int Hash(string key);
    void ReHash();
    bool Insert(T item);
    bool Remove(T item);
    bool Exists(T item, out int itemPosition);
    List<T> Content();
    bool isPrime(int size);
    int ResizeTable(int size);
}
