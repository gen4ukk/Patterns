namespace Decorator
{
    internal class WaveModifierDecorator : FileModifierDecorator
    {
        public WaveModifierDecorator(IFileModifier fileModifier) : base(fileModifier)
        {
        }

        public override void WriteToFile(string path, string text)
        {
            File.AppendAllText(path, "~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine);

            base.WriteToFile(path, text);

            File.AppendAllText(path, "`````````````````````````" + Environment.NewLine);
        }
    }
}
