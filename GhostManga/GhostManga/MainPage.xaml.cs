using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //display message when search word is empty
            if (searchWord.Text == null)
            {
                await DisplayAlert("buttonClick","You didnt search anything", "ok");
            }
            //if not type is selected title will be the default  
            else if (searchType.SelectedItem == null)
            {
                await DisplayAlert("buttonClick", "Searchword= " + searchWord.Text + "\nSearchType= title" , "ok");
            }
            //everything that was typed and selected
            else
                await DisplayAlert("buttonClick","Searchword= "+searchWord.Text+"\nSearchType= "+searchType.SelectedItem,"ok");
        }
    }
}
