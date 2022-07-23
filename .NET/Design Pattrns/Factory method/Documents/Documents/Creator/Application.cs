namespace Documents.Pattern
{
    abstract class Application
    {
        public abstract Document CreateDocument();
        public abstract void OpenDocument();
    }
}
