namespace Перегрузка_Обобщение;

public class Stack<T>
{
  private List<T> _items;
    
  public Stack()
  {
    _items = new List<T>();
  }
    
  public void Push(T item)
  {
    _items.Add(item);
  }
    
  public T Pop()
  {
    if (_items.Count == 0)
      return default;
        
    T item = _items[_items.Count - 1];
    _items.RemoveAt(_items.Count - 1);
    return item;
  }
    
  public T Peek()
  {
    if (_items.Count == 0)
      return default;
        
    return _items[_items.Count - 1];
  }
    
  public bool IsEmpty()
  {
    return _items.Count == 0;
  }
}