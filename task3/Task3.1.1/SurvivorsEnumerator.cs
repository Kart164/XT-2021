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
        private int _curIndex;
        private int _current;
        public int Current => _current;
        object IEnumerator.Current => _current;

        public SurvivorsEnumerator(List<int> list)
        {
            _list = list;
            _curIndex = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (++_curIndex >= _list.Count)
            {
                _curIndex=0;
                _current = _list[_curIndex];
                return true;
            }
            else
            {
                _current = _list[_curIndex];
                return true;
            }
        }
        public void GoBackOnStep()
        {
            if (_curIndex > 0)
            {
                _curIndex -= 1;
            }
            else _curIndex = _list.Count - 1;
        }
        public void Reset()
        {
            _curIndex = -1;
        }
    }
}
