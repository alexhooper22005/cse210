//Responsiblity: Convert the words to dashes

using System;
using System.Runtime.CompilerServices;

public class Word
{
    private string _originalWord;
    private bool _isHidden;

    public Word(string originalWord)
    {
        _originalWord = originalWord;
        _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
    }

    public string ReplaceWord()
    {
        if (!_isHidden)
        {
            return _originalWord;
        }

        char[] chars = _originalWord.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (Char.IsLetterOrDigit(chars[i]))
            {
                chars[i] = '_';
            }
        }

        return new string(chars);

      

    }
}
