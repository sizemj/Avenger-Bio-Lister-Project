using System;
using System.Collections.Generic;
using System.Text;

namespace AvengersBioLister
{
    public class MenuOption
    {
        public MenuOption(string itemText)
        {
            ItemText = itemText;
        }
        public string ItemText { get; }
    }
}
