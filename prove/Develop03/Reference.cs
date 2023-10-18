using System;

class Reference
{
    private string _reference;

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    } 

    public List<int> ParseReference()
    {
        List<int> parsedReference = new List<int>();

        if (!string.IsNullOrEmpty(_reference))
        {
            string[] parts = _reference.Split(' ');
            if (parts.Length == 2)
            {
                string[] chapterVerse = parts[1].Split(':');
                if (chapterVerse.Length == 2)
                {
                    if (int.TryParse(chapterVerse[0], out int chapter) &&
                    int.TryParse(chapterVerse[1], out int endVerse))
                    {
                        if (chapterVerse.Length == 2)
                        {
                            for (int verse = chapter; verse <= endVerse; verse++)
                            {
                                parsedReference.Add(chapter * 1000 + verse);
                            }
                        }
                    }
                }
            }
        }
            return parsedReference;
    }
}