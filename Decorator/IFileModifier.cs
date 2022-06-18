namespace Decorator
{
    internal interface IFileModifier
    {
        void WriteToFile(string path, string text);
        void RemoveFile(string path);
    }
}
