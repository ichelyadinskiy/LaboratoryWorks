using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Bucket
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public Bucket Next { get; set; }

        public Bucket(object key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
