using NBATeamTwitterTrends.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace NBATeamTwitterTrends
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        public async void loadTwitterResultsforFavoriteTeam()
        {
            TwitterSearchViewModel favoriteTeamSearch = new TwitterSearchViewModel();
            await favoriteTeamSearch.OpenTwitterConnection(App.favoriteTeam, 30);
            this.tweetsForFavoriteTeam.ItemsSource = favoriteTeamSearch.tweetList; 
        }

        public async void loadTwitterResultsforAllTeams()
        {
            TwitterSearchViewModel allNBASearch = new TwitterSearchViewModel();
            await allNBASearch.OpenTwitterConnection("NBA", 30);
            this.tweetsForAllTeams.ItemsSource = allNBASearch.tweetList;
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.


            // *** FLECK Comments:
            // Check if Favorite Team is registerted.
            // If so, Load data from Twitter for that team on the Team Pivot
            // If not, inform there is not Favorite Team saved

            if (string.IsNullOrEmpty(App.favoriteTeam))
            {
                ApplicationDataContainer appSettings = ApplicationData.Current.LocalSettings;
                if (appSettings.Containers.ContainsKey("favoriteTeam"))
                {   
                    App.favoriteTeam = appSettings.Values["favoriteTeam"].ToString();
                    this.tweetsForFavoriteTeam.Header = appSettings.Values["favoriteTeam"].ToString();
                }
                else
                {
                    this.tweetsForFavoriteTeam.Header = "Select Your Favorite Team";
                }
            }
            else
            {
                this.tweetsForFavoriteTeam.Header = App.favoriteTeam;
            }
            if(!string.IsNullOrEmpty (App.favoriteTeam))
            {
                this.loadTwitterResultsforFavoriteTeam();
            }
            this.loadTwitterResultsforAllTeams();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            //this.favoriteTeamName.Text = "Button + Tapped";
            Frame.Navigate(typeof(AddChangeFavorite));
        }
    }
}
