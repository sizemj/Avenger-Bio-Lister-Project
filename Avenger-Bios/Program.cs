namespace AvengersBioLister
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();

            //Set up my menu options
            var options = menu.BuildMainMenu();

            menu.DisplayMainMenu(options);

            //Gets choice form user.
            menu.GetMenuSelection(options);
        }
    }
}
