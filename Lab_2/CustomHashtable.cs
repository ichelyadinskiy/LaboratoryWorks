using System;
using System.Collections.Generic;
using System.Management.Instrumentation;

namespace Lab_2
{
    public class CustomHashtable
    {
        private readonly Bucket[] _buckets;
        private readonly object _locker = new object();
        public int Count { get; private set; }

        public CustomHashtable(int tableSize)
        {
            Count = 0;
            _buckets = new Bucket[tableSize];
        }

        public void Add(object key, object value)
        {
            lock (_locker)
            {
                Insert(key, value);
            }
        }

        public object Find(object key)
        {
            var hash = GetHash(key);
            var current = _buckets[hash];

            if (current == null)
                throw new InstanceNotFoundException("Value was not found!");

            while (current.Next != null)
            {
                if (current.Key == key)
                    return current.Value;
                current = current.Next;
            }
            throw new InstanceNotFoundException("Value was not found!");
        }

        public void Delete(object key)
        {
            var hash = GetHash(key);
            var current = _buckets[hash];

            if (current == null)
                throw new InstanceNotFoundException("Value was not found!");

            var bucketsTemp = new List<Bucket>();
            while (current != null)
            {
                bucketsTemp.Add(current);
                current = current.Next;
            }

            for (var i = 0; i < bucketsTemp.Count; i++)
            {
                if (bucketsTemp[i].Key != key) continue;
                if (i == 0)
                {
                    _buckets[hash] = bucketsTemp[i].Next;
                    return;
                }
                bucketsTemp[i - 1].Next = bucketsTemp[i].Next;
                bucketsTemp.RemoveAt(i);
            }
            _buckets[hash] = bucketsTemp[0];
        }

        private void Insert(object key, object value)
        {
            var hash = GetHash(key);
            var bucket = new Bucket(key, value);

            if (_buckets[hash] != null)
                bucket.Next = _buckets[hash];
            _buckets[hash] = bucket;
        }

        private int GetHash(object key)
        {
            return Math.Abs(key.GetHashCode())%_buckets.Length;
        }
    }
}
