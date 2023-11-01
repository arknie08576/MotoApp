
namespace MotoApp
{
    internal class BasicStack<T>
    {
        private readonly T[] _items;
        private int currentIndex = -1;
        public BasicStack() => _items = new T[10];
        public T Pop() => _items[currentIndex--];
        public void Push(T item) => _items[++currentIndex] = item;
        public int Count => currentIndex + 1;
    }
}
