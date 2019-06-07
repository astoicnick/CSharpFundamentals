using System;
using _1150_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1150_MenuTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void MenuTest()
        {
            MenuRepository menuRepo = new MenuRepository();
            Menu sampleMenu = new Menu("Pizza", 8.50, true, DrinkSize.BigBoy);

           //menuRepo.AddContentToList(sampleMenu); 
            Assert.IsTrue(menuRepo.AddContentToList(sampleMenu));
        }
    }
}
