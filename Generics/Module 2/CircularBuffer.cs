namespace Generics.Module_2
{

    public class CircularBuffer<T> : Buffer<T>
    {
        private int _capacity;

        public CircularBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }
    }
}