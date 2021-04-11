using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3._1._1
{
    public class Survivors : IEnumerable<int>
    {
        private List<int> _people;
        public int Count => _people.Count;
        public Survivors(int n)
        {
            _people = new List<int>(Enumerable.Range(1, n));
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SurvivorsEnumerator(_people);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void StartGame(int n)
        {
            int round = 0;
            var enumerator = (SurvivorsEnumerator)GetEnumerator();
            while (Count >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    enumerator.MoveNext();
                }
                _people.Remove(enumerator.Current);
                enumerator.GoBackOnStep();
                round++;
                Console.WriteLine($"Раунд {round}. Вычеркнут человек. Людей осталось: {Count}");
                Console.WriteLine(ToString());
            }
            Console.WriteLine($"Игра закончилась, невозможно больше вычеркнуть людей");
            Console.WriteLine($"Победил(-и): {ToString()}");
        }
        public override string ToString()
        {
            var sb = new StringBuilder(Count * 2);
            foreach (var item in _people)
            {
                sb.Append(item + " ");
            }
            return sb.ToString();
        }
    }
}
