using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Conveyor<T> : IConveyor<T> {

        public Queue<T> _queue = new Queue<T>();
        public IEnumerable <T>Print (IEnumerable<T> _queue) {
            var converter=TypeDescriptor.GetConverter (typeof (T));
            foreach (var item in _queue) {
                T result = (T)converter.ConvertTo(item, typeof(T));
          yield return item;
          }
        }

        public bool IsEmpty {
            get {
                return _queue.Count == 0;

            }
        }

        public void Push(T type) {

            // Queue<T> _pushtype = new Queue<T>();
            _queue.Enqueue( type);
            // _queue.Enqueue(new Type { ProductName = "", ProductType = "", Description = "", CurrentPrice =''};


        }

        public T Pull() {

            return _queue.Dequeue();

        }

   


    }
}

