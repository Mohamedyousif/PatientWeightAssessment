using System.IO;

namespace RavenDBHelper.Helpers
{
    public class TextFileHelper
    {
        public static string ReadFileString(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
