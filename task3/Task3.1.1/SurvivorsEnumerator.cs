using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1._1
{
    public class SurvivorsEnumerator : IEnumerator<int>
    {
        private List<int> _list;
        public int CurIndex { get; private set; }
        private int _current;
        public int Current => _current;
        object IEnumerator.Current => _current;

        public SurvivorsEnumerator(List<int> list)
        {
            _list = list;
            CurIndex = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (++CurIndex >= _list.Count)
            {
                CurIndex = 0;
                _current = _list[CurIndex];
                return true;
            }
            else
            {
                _current = _list[CurIndex];
                return true;
            }
        }
        public void Reset()
        {
            CurIndex = -1;
        }
    }
}
