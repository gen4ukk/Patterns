namespace Decorator
{
    internal abstract class FileModifierDecorator : IFileModifier
    {
        protected IFileModifier _fileModifier;

        public FileModifierDecorator(IFileModifier fileModifier)
        {
            _fileModifier = fileModifier;
        }

        public virtual void RemoveFile(string path)
        {
            _fileModifier.RemoveFile(path);
        }

        public virtual void WriteToFile(string path, string text)
        {
            _fileModifier.WriteToFile(path, text);
        }
    }
}
