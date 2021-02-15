namespace Core
{
    public static class ModeCharacterFinder
    {
        /// <summary>
        /// Returns the character with most occurences in the text.
        /// Case is ignored.
        /// If there are multiple characters with equal highest occurence,
        /// the one that appeared first in the text is returned.
        /// https://en.wikipedia.org/wiki/Mode_(statistics)
        /// </summary>
        public static char Find(string text)
        {
            return char.MinValue;
        }
    }
}
