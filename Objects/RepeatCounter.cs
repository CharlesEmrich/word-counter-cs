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

    }
    public Dictionary<string, int> CountRepeats()
    {
      
      return _counts;
    }
  }
}
