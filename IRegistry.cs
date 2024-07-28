// 23521 - Gustavo Cruz

using System.IO;

public interface IRegistry<T>
{
  void ReadRegistry(StreamReader file);
  void WriteData(StreamWriter file);
  bool Equals(object obj);
  string Key { get; }
}
