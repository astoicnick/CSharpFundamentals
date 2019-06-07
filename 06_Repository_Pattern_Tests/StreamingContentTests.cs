using System;
using _06_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentPOCOTests()
        {
            StreamingContent content = new StreamingContent("Rubber", GenreType.Horror, 
                "The best movie ever", 125d, 5.8d, "R", false);


            Assert.AreEqual(GenreType.Horror, content.TypeOfGenre);
            Assert.AreEqual("R", content.MaturityRating);

        }

        [TestMethod]
        public void StreamingContentRepositoryAddToList()
        {
            StreamingContentRepository contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent("Toy story", GenreType.Bromance, "Good",
                120d, 8d, "PG13", true);

            contentRepo.AddContentToList(content);

            int expected = 1;
            int actual = contentRepo.GetStreamingContentList().Count;

            Assert.AreEqual(expected,actual);

            contentRepo.GetContentByTitle("Toy story");

            string expectedTitle = "Toy story";
            Assert.AreEqual(content, contentRepo.GetContentByTitle(expectedTitle));

            int expectedRemoveCount = 0;
            contentRepo.RemoveContentFromList(content);
            int actualRemoveCount = contentRepo.GetStreamingContentList().Count;
            Assert.AreEqual(expectedRemoveCount, actualRemoveCount);

        }
    }
}
