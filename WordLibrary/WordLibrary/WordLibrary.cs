namespace WordLibrary
{
    public class WordLibrary
    {
        public static string GetVowelByNumber(ushort pNumber)
        {
            if (pNumber == 0)
            {
                throw (new System.ArgumentNullException());
            }
            if(pNumber == 1)
            {
                return "a";
            }
            return "";
        }
    }
}