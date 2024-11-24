public class Scripture
{
    private List<Word> _words; 
    private Reference _scriptureReference; 

    public Scripture(Reference reference, string text)
    {
        _scriptureReference = reference; 

        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();

    List<int> unhiddenIndex = new List<int>();
    for (int i = 0; i < _words.Count; i++)
    {
        if (!_words[i].IsHidden())
        {
            unhiddenIndex.Add(i);
        }
    }

    if (unhiddenIndex.Count <= numberToHide)
    {
        foreach (int index in unhiddenIndex)
        {
            _words[index].Hide();
        }
        return;
    }

    int hiddenCount = 0;
    while (hiddenCount < numberToHide)
    {
        int randomIndex = random.Next(unhiddenIndex.Count);
        int wordIndex = unhiddenIndex[randomIndex];

        _words[wordIndex].Hide();
        unhiddenIndex.RemoveAt(randomIndex);
        hiddenCount++;
    }
}

    public string GetDisplayText()
    {
        string referenceText = _scriptureReference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        return $"{referenceText}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}