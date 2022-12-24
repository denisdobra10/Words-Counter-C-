namespace WordsCounter
{
    public class Counter
    {
        private string sentence;
        private int sentenceLength;
        private int sentenceLengthWithoutWhiteSpaces;

        private string[] wordsList;
        private int wordsCount;

        private Dictionary<string, int> wordsDictionary;



#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Counter(string _sentence) => Setup(_sentence);
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        private void Setup(string _sentence)
        {
            this.sentence = _sentence;
            this.sentenceLength = sentence.Length;
            sentenceLengthWithoutWhiteSpaces = 0;
            foreach (string word in sentence.Split(' '))
                sentenceLengthWithoutWhiteSpaces += word.Length;

            this.wordsList = sentence.Split(' ');
            this.wordsCount = wordsList.Length;

            // Setup wordsDictionary
            this.wordsDictionary = new Dictionary<string, int>();
            CalculateWords();
        }


        // Getters
        public string GetSentence() { return this.sentence; }

        public int GetSentenceLength() { return this.sentenceLength; }

        public string[] GetWordsList() { return this.wordsList; }

        public int GetWordsCount() { return this.wordsCount; }

        public int GetSentenceLengthWithoutWhiteSpaces() { return this.sentenceLengthWithoutWhiteSpaces; }



        // Private methods
        private void CalculateWords()
        {
            foreach (string word in wordsList)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }
        }


        // Public Methods
        public Dictionary<string, int> GetWordsDictionary() { return this.wordsDictionary; }

        public void UpdateSentence(string _sentence)
        {
            Setup(_sentence);
        }
    }
}
