using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    public Scripture()
    {
        _reference = new Reference("John", 3, 16);
        _words = RemoveSpaces();
    }

    public List<string> _scriptureTexts = new List<string> { "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." };
    
    private List<string> _words;

    public string GetReferenceText()
    {
        return _reference.SetReference();
    }

    public void Display()
    {


        foreach (var item in _scriptureTexts)
        {
            Console.WriteLine(item);
        }
    }

    public List<string> HideWords()
    {
        Random random = new Random();
        int wordsToHide = 3;
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int idx = random.Next(0, _words.Count);

            if (!_words[idx].Contains("_"))
            {
                Word word1 = new Word(_words[idx]);
                word1.Hide();
                _words[idx] = word1.ReplaceWord();
                hiddenCount++;
            }

            if (AllWordsHidden())
            {
                break;
            }
        }

        return _words;
    }

    private bool AllWordsHidden()
    {
        foreach (string word in _words)
        {
            if (!word.Contains("_"))
            {
                return false;
            }
        }
        return true;
    }

    public List<string> RemoveSpaces()
    {
        List<string> wordsNoSpaces = new List<string>();

        foreach (string text in _scriptureTexts)
        {
            string[] splitWords = text.Split(" ");
            foreach (string word in splitWords)
            {
                wordsNoSpaces.Add(word);
            }
        }

        return wordsNoSpaces;
    }
}