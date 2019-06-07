using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern
{
    public class StreamingContentRepository : IStreamingRepository
    {
        public void AddInitialContent()
        {
            StreamingContent toyStory = new StreamingContent("Toy Story", GenreType.Bromance, "toy story movie",
            110, 4.5, "E", true);
            StreamingContent toyStoryTwo = new StreamingContent("Toy Story Two", GenreType.Bromance, "toy story two movie",
                110, 4.5, "E", true);
            AddContentToList(toyStory);
            AddContentToList(toyStoryTwo);
        }
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }
        public List<StreamingContent> GetStreamingContentList()
        {
            return _listOfContent;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if ( title.ToLower() == content.Title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public bool RemoveContentFromList(StreamingContent content)
        {
            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class FakeRepository : IStreamingRepository
    {
        public void AddContentToList(StreamingContent content)
        {
            return;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            return null;
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return new List<StreamingContent>() { new StreamingContent() };
        }

        public bool RemoveContentFromList(StreamingContent content)
        {
            return true;
        }
    }
}
