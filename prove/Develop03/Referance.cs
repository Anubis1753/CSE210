class Referance
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Referance(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = verse;
    }

    public Referance(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }

    public string Display()
    {
        if (_verse == _endverse)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endverse}";
        }
    }
}