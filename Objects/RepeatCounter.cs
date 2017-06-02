using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _corpus;
    private string[] _corpusSplit;
    // private List<string> _searchTerms = new List<string> {};
    private string[] _searchTerms;
    private Dictionary<string, int> _counts = new Dictionary<string, int> {};

    public RepeatCounter(string corpus, string searchTerms)
    {
      _corpus = corpus;
      _corpusSplit = _corpus.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
      _searchTerms = searchTerms.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
    }
    public Dictionary<string, int> CountRepeats()
    {
      foreach (string query in _searchTerms) {
        _counts.Add(query, 0);
      }
      foreach (string word in _corpusSplit) {
        if (_counts.ContainsKey(word)) {
          _counts[word] ++;
        }
      }
      return _counts;
    }
  }
}
