namespace Impactly_PDF_Generator.Utilities
{
    public interface IStringUtility
    {
        List<string> SplitIntoLines(string text, int lineLength);
    }

    public class StringUtility : IStringUtility
    {
        public List<string> SplitIntoLines(string text, int lineLength)
        {
            List<string> lines = new List<string>();

            if (string.IsNullOrEmpty(text))
            {
                lines.Add("");
                return lines;
            }

            int startIndex = 0;

            while (startIndex < text.Length)
            {
                int length = Math.Min(lineLength, text.Length - startIndex);
                string line = text.Substring(startIndex, length);
                lines.Add(line);
                startIndex += length;
            }

            return lines;
        }
    }

}
