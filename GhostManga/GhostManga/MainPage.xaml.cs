using GhostManga.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GhostManga
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void searchClick(object sender, EventArgs args)
        {
            SearchClass s = new SearchClass();

            //display message when search word is empty
            if (searchWord.Text == null)
            {
                await DisplayAlert("buttonClick", "You didnt search anything", "ok");
            }
            //if not type is selected title will be the default  
            else if (searchType.SelectedItem == null)
            {
                string word = searchWord.Text;
                s.GetSearchList(word, "title", "1");
                await DisplayAlert("Search made", "Looks like there are " + s.SB.numOfManga + " manga with horror in the title", "ok");
            }
            //everything that was typed and selected
            else
            {
                string word = searchWord.Text;
                string typeword = searchType.SelectedItem.ToString();
                s.GetSearchList(word, typeword, "1");
                await DisplayAlert("Search made", "Looks like there are " + s.SB.numOfManga + " manga with horror in the title", "ok");
            }
        }
    }
}
