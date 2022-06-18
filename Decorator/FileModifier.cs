namespace Decorator
{
    internal class FileModifier : IFileModifier
    {
        public void RemoveFile(string path)
        {
            File.Delete(path);
        }

        public void WriteToFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }
    }
}
