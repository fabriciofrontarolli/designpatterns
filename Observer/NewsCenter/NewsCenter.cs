using Observer.Reporters;
using System.Collections.Generic;

namespace Observer.NewsCenter
{
    public class NewsCenter
    {
        private IList<IReporter> associatedReporters = new List<IReporter>();


        public void AssociateReporter(IReporter reporter)
        {
            associatedReporters.Add(reporter);
        }


        public void DisassociateReporter(IReporter reporter)
        {
            associatedReporters.Remove(reporter);
        }


        public void NotifyBreakingNewsToAssociatedReporters(string headline)
        {
            foreach (var reporter in associatedReporters)
            {
                reporter.NotifyBreakingNews(headline);
            }
        }
    }
}