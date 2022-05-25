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
            if (searchWord.Text == null)
            {
                await DisplayAlert("buttonClick","You didnt search anything", "ok");
            }
            else if (searchType.SelectedItem == null)
            {
                await DisplayAlert("buttonClick", "Searchword= " + searchWord.Text + "\nSearchType= title" , "ok");
            }
            else
            await DisplayAlert("buttonClick","Searchword= "+searchWord.Text+"\nSearchType= "+searchType.SelectedItem,"ok");
        }
    }
}
