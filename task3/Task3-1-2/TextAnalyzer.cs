using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3_1_2
{
    public class TextAnalyzer
    {
        private string _text;
        private Dictionary<string, int> _wordsAndTheirCount;
        private int _countOfWords;
        public TextAnalyzer(string text)
        {
            _text = text.ToLower();
            _wordsAndTheirCount = new Dictionary<string, int>();
            _countOfWords = 0;
        }

        private void DeleteSeparators()
        {
            var regex = new Regex(@"([.,;:!?]+)\s");
            _text = regex.Replace(_text, " ");
        }
        public void InitializeDictionary()
        {
            DeleteSeparators();
            var words = _text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            _countOfWords = words.Length;
            foreach (string word in words)
            {
                if (!_wordsAndTheirCount.ContainsKey(word))
                {
                    _wordsAndTheirCount.Add(word, 1);
                }
                else
                {
                    _wordsAndTheirCount[word]++;
                }
            }
        }

        public Dictionary<string, int> GetFullAnalysis()
        {
            return _wordsAndTheirCount;
        }
        public Dictionary<string, int> GetShortAnalysis()
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in _wordsAndTheirCount)
            {
                if ((word.Value / (double)_countOfWords) * 100 > 1)
                {
                    dict.Add(word.Key, word.Value);
                }
            }
            return dict;
        }
    }
}
