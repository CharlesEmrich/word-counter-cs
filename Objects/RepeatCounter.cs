using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _corpus;
    private List<string> _searchTerms = new List<string> {};
    private Dictionary<string, int> _counts = new Dictionary<string, int> {};

    public RepeatCounter(string corpus, string searchTerms)
    {
      _corpus = corpus;
      _searchTerms.Add(searchTerms);
    }
    public Dictionary<string, int> CountRepeats()
    {
      foreach (string query in _searchTerms) {
        if (_corpus.Contains(query)) {
          _counts.Add(query, 1);
        }
      }
      return _counts;
    }
  }
}
