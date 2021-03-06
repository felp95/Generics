﻿using System.Collections;
using System.Collections.Generic;

namespace Generics.Module_2
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpty()
        {
            return _queue.Count == 0;
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                //...
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}