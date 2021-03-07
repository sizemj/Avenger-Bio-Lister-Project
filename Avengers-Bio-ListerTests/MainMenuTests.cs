using Xunit;
using AvengersBioLister;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvengersBioLister.Tests
{
    public class MainMenuTests
    {
        [Fact()]
        public void BuildMainMenuTest()
        {
            //Arrange 
            var menu = new MainMenu();

            //Act
            List<MenuOption> menuItems = menu.BuildMainMenu();

            //Assert 
            Assert.False(menuItems.Count == 0);
            Assert.Contains("Vision", menuItems[10].ItemText);
        }


    }
}
