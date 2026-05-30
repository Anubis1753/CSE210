using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Referance _referance;
    private List<Word> _words;

    public Scripture(Referance referance, string text)
    {
        _referance = referance;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach(string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
        int visibleWords = 0;

        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords ++;
            }
        }
        int actualNemberToHIde = Math.Min(numberToHide, visibleWords);

        while(wordsHidden < actualNemberToHIde)
        {
            int index = random.Next(_words.Count);

            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden ++;
            }
        }
    }

    public string Display()
    {
        string scriptureText = "";
        foreach(Word word in _words)
        {
            scriptureText +=word.Display() + " ";
        }
        return $"{_referance.Display()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}