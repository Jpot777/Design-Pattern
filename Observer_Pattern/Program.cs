namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.Play();
            subject.Notify();
        }
    }
}
