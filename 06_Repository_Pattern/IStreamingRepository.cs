using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern
{
    public interface IStreamingRepository
    {
        void AddContentToList(StreamingContent content);
        List<StreamingContent> GetStreamingContentList();
        StreamingContent GetContentByTitle(string title);
        bool RemoveContentFromList(StreamingContent content);
    }
}
