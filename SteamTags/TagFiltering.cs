using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamTags
{
    class TagFiltering
    {
        public void run(CheckedListBox checkedListBox1, CheckedListBox checkedListBox2, WebBrowser webBrowser1)
        {
            navigate(webBrowser1, categoryList(checkedListBox1), specifierList(checkedListBox2));
        }
        public string categoryList(CheckedListBox checkedListBox1)
        {
            string categoryId = "";
            switch (checkedListBox1.SelectedItem.ToString())
            {
                case "Shooter":
                    categoryId = checkedListBox1.SelectedItem.ToString(); //1774
                    break;
                case "Indie":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Adventure":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Strategy":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "RPG":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Free to Play":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Casual":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Multiplayer":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Singleplayer":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Racing":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Horror":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Platformer":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Survival":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Simulation":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Fantasy":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Anime":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Turn-Based":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Space":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                case "Memes":
                    categoryId = checkedListBox1.SelectedItem.ToString();
                    break;
                default:
                    categoryId = "1";
                    break;
            }
            return categoryId;
        }
        public int specifierList(CheckedListBox checkedListBox2)
        {
            int specifierId = 0;
            if (checkedListBox2.SelectedItem != null)
            {
                switch (checkedListBox2.SelectedItem.ToString())
                {
                    case "Free to Play":
                        specifierId = 113;
                        break;
                    case "Multiplayer":
                        specifierId = 3859;
                        break;
                    case "Singleplayer":
                        specifierId = 4182;
                        break;
                    case "Casual":
                        specifierId = 597;
                        break;
                    case "Turn-Based":
                        specifierId = 1677;
                        break;
                    default:
                        break;
                }
            } 
            return specifierId;
        }

        private void navigate(WebBrowser webBrowser1, string category, int specifier)
        {
            
            //string selectedCategory = "http://store.steampowered.com/tag/browse/#global_" + categoryId;
            string selectedCategory = "http://store.steampowered.com/tag/en/" + category + "/#p=0&tab=TopSellers";
            if (specifier != 0)
            {
                selectedCategory = "http://store.steampowered.com/tag/en/" + category + "/#tag[]=" + specifier + "&p=0&tab=TopSellers";
            }
            try
            {
                webBrowser1.Navigate(new Uri(selectedCategory));
            }
            catch (System.UriFormatException)
            {
                webBrowser1.Navigate(new Uri("https://www.google.dk/search?q=404+not+found&ie=utf-8&oe=utf-8&gws_rd=cr&ei=uQ3UVtqrFaqy6ATyrZiYDw"));
            }
        }
        
    }
}
