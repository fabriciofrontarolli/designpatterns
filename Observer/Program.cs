using Observer.Reporters;
using System;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newsCenter = new NewsCenter.NewsCenter();

            IReporter cnnReporter = new CNNReporter();
            IReporter bbcReporter = new BBCReporter();

            newsCenter.AssociateReporter(cnnReporter);
            newsCenter.AssociateReporter(bbcReporter);

            newsCenter.NotifyBreakingNewsToAssociatedReporters("Attention: Now it's allowed to commit without unit tests!");

            Console.WriteLine("Disassociating CNN Reporter...");
            Console.WriteLine(Environment.NewLine);
            newsCenter.DisassociateReporter(cnnReporter);

            newsCenter.NotifyBreakingNewsToAssociatedReporters("Attention: Developer states that it works in his machine!");

            Console.ReadKey();
        }
    }
}