using System;

namespace Observer.Reporters
{
    public class CNNReporter : IReporter
    {
        public string Name { get { return "CNN Reporter"; }}

        public void NotifyBreakingNews(string headline)
        {
            Console.Write(string.Format("{0}: Informing: {1}", Name, headline));
            Console.WriteLine(Environment.NewLine);
        }
    }
}