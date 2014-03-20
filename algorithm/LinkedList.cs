using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm {
    public class LinkedList<T> : IEnumerable<T>, IEnumerator<T> {
        private LinkNode<T> _first;
        private LinkNode<T> _last;

        private LinkNode<T> _current;

        public LinkedList() {
            _first = _last = null;
        }

        public bool IsEmpty() {
            return _first == null;
        }

        public void InsertAtFront(LinkNode<T> node) {
            if (this.IsEmpty()) {
                _last = _first = node;
            } else {
                node.Next = _first;
                _first = node;
            }
        }

        public void RemoveAtFront() {
            if (!this.IsEmpty()) {
                _first = _first.Next;
            }
        }

        public void InsertAtEnd(LinkNode<T> node) {
            if (this.IsEmpty()) {
                _last = _first = node;
            } else {
                _last.Next = node;
                _last = node;
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for (LinkNode<T> cur = _first; cur != null; cur = cur.Next) {
                sb.AppendLine(cur.Data.ToString());
            }

            return sb.ToString();
        }


        private T GetDataFronCurrent() {
            _current = _current ?? _first;
            if (_current == null) {
                return default(T);
            } else {
                return _current.Data;
            }
        }

        #region IEnumerable<T> 成员

        public IEnumerator<T> GetEnumerator() {
            return this as IEnumerator<T>;
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this as System.Collections.IEnumerator;
        }

        #endregion

        #region IEnumerator<T> 成员

        public T Current {
            get {
                return GetDataFronCurrent();
            }
        }

        #endregion

        #region IDisposable 成员

        public void Dispose() {
            _first = _last = _current = null;
        }

        #endregion

        #region IEnumerator 成员

        object System.Collections.IEnumerator.Current {
            get { return GetDataFronCurrent(); }
        }

        public bool MoveNext() {
            if (this.IsEmpty()) return false;
            if (_current == null) {
                _current = _first;
            } else {
                _current = _current.Next;
            }

            return _current != null;
        }

        public void Reset() {
            _current = null;
        }

        #endregion
    }

    public class LinkNode<T> {
        public LinkNode(T data)
            : this(data, null) { }

        public LinkNode(T data, LinkNode<T> next) {
            this.Data = data;
            this.Next = next;
        }
        public T Data { get; set; }
        public LinkNode<T> Next { get; set; }
    }

}
