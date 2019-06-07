using _06_Repository_Pattern;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace _06_Repository_Pattern_Console
{
    public class ProgramUI
    {
        private readonly IStreamingRepository _contentRepo;

        public ProgramUI(IStreamingRepository repo)
        {
            _contentRepo = repo;
        }
        public void Run()
        {

            StreamingContent toyStoryI = new StreamingContent("toy story", GenreType.Bromance, "toy story movie",
            110, 4.5, "E", true);
            StreamingContent toyStoryII = new StreamingContent("toy story two", GenreType.Bromance, "toy story two movie",
                110, 4.5, "E", true);
            _contentRepo.AddContentToList(toyStoryI);
            _contentRepo.AddContentToList(toyStoryII);
            while (Menu())
            {
            }
        }

        private bool Menu()
        {
            Console.WriteLine("What would you like to do?" +
                "\n1. Add content to streaming library " +
                "\n2. Check out the streaming library" +
                "\n3. Delete an entry from the streaming library" +
                "\n4. Exit" +
                "\n5. Find streaming content by title");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("What's the title?");
                    string title = Console.ReadLine();

                    Console.WriteLine("What genre is it? The options are: ");
                    GenreType userGenre = new GenreType();
                    foreach (GenreType genre in Enum.GetValues(typeof(GenreType)))
                    {
                       Console.WriteLine(genre);
                    }
                    string genreTypeString = Console.ReadLine();
                    foreach (GenreType genre in Enum.GetValues(typeof(GenreType)))
                    {
                        if (genre.ToString().ToLower() == genreTypeString.ToLower())
                        {
                            userGenre = genre;
                        }
                    }


                    Console.WriteLine("What's the Description?");
                    string description = Console.ReadLine().ToLower();

                    Console.WriteLine("What's the Runtime(in minutes)?");
                    string runTime = Console.ReadLine();
                    double runTimeMinutes = int.Parse(runTime);

                    Console.WriteLine("What's the Star Rating?");
                    string starRatingString = Console.ReadLine();
                    double starRating = double.Parse(starRatingString);

                    Console.WriteLine("What's the Maturity Rating?");
                    string maturityRating = Console.ReadLine();

                    Console.WriteLine("Is the video family friendly (Y/N)?");
                    bool familyFriendly = false;
                    string familyFriendlyString = Console.ReadLine().ToLower();
                    switch (familyFriendlyString)
                    {
                        case "y":
                            familyFriendly = true;
                            break;
                        case "n":
                            familyFriendly = false;
                            break;
                    }

                    StreamingContent contentAdded = new StreamingContent(title, userGenre, description, runTimeMinutes,
                        starRating, maturityRating, familyFriendly);
                    int initCount = _contentRepo.GetStreamingContentList().Count;
                    _contentRepo.AddContentToList(contentAdded);
                    if (_contentRepo.GetStreamingContentList().Count > initCount)
                    {
                        Console.WriteLine("Awesome! Put that content in for ya.");
                    }
                    else
                    {
                        Console.WriteLine("Please try to add that item again.");
                    }
                    break;
                case "2":
                    foreach (StreamingContent item in _contentRepo.GetStreamingContentList())
                    {
                        Console.WriteLine("Title: " + item.Title);
                        Console.WriteLine("Genre: " + item.TypeOfGenre);
                        Console.WriteLine("Description: " + item.Description);
                        Console.WriteLine("Runtime: " + item.RunTimeInMinutes);
                        Console.WriteLine("Star rating: " + item.StarRating);
                        Console.WriteLine("Maturity Rating: " + item.MaturityRating);
                        if (item.IsFamilyFriendly)
                        {
                            Console.WriteLine("Family Friendly: Yes");
                        }
                        else
                        {
                            Console.WriteLine("Family Friendly: No");
                        }
                        Console.WriteLine("----------------------");
                    }
                    break;
                case "3":
                    Console.WriteLine("What's the name of the content you'd like to remove?");
                    string contentToRemove = Console.ReadLine();
                    StreamingContent contentToRemoveObject = new StreamingContent();
                    foreach (StreamingContent content in _contentRepo.GetStreamingContentList())
                    {
                        if (content.ToString() == contentToRemove)
                        {
                            contentToRemoveObject = content;
                        }
                    }
                    _contentRepo.RemoveContentFromList(contentToRemoveObject);
                    if (_contentRepo.RemoveContentFromList(contentToRemoveObject))
                    {
                        Console.WriteLine("I removed it for you!");
                    }
                    else
                    {
                        Console.WriteLine("Operation failed :( please try again.");
                    }
                    break;
                case "4":
                    return false;
                    //Environment.Exit(-1);
                    break;
                case "5":
                    Console.WriteLine("What's the title of the content you'd like to find?");
                    string titleToFind = Console.ReadLine();
                    StreamingContent contentFound = _contentRepo.GetContentByTitle(titleToFind);
                    Console.WriteLine("----------------------");
                    foreach  (PropertyInfo prop in contentFound.GetType().GetProperties())
                    {
                        Console.WriteLine(prop.GetValue(contentFound));
                    }
                    break;
                default:
                    Console.WriteLine("Please re-type your answer");
                    break;
            }
            Console.WriteLine("");
            return true;
        }
    }
}
