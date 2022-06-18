namespace Decorator
{
    internal class FileStartModifierDecorator : FileModifierDecorator
    {
        public FileStartModifierDecorator(IFileModifier fileModifier) : base(fileModifier)
        {
           
        }

        public override void RemoveFile(string path) 
        {
            base.RemoveFile(path);
        }

        public override void WriteToFile(string path, string text)
        {
            File.AppendAllText(path, "+++++++++++++++++++++++++" + Environment.NewLine);

            base.WriteToFile(path, text);

            File.AppendAllText(path, "-------------------------" + Environment.NewLine);
        }
    }
}
