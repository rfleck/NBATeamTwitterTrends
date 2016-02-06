using NBATeamTwitterTrends.Model;
using NBATeamTwitterTrends.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace NBATeamTwitterTrends
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddChangeFavorite : Page
    {
        public void InitiateTeamList()
        {
            TeamListViewModel AppTeamList = new TeamListViewModel();
            teamsAvailable.ItemsSource = AppTeamList.InitiateListValues();
        }

        public AddChangeFavorite()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            //throw new NotImplementedException();
            if (Frame.CanGoBack)
                Frame.GoBack();

            e.Handled = true;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Prepare List with Favorite Team Saved
            // Load list of Teams Available for User Choice
            this.InitiateTeamList();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (teamsAvailable.SelectedItem != null && teamsAvailable.SelectedItem.GetType() == typeof(NBATeamModel))
            {
                string name = ((NBATeamModel)this.teamsAvailable.SelectedItem).teamName;
                string city = ((NBATeamModel)this.teamsAvailable.SelectedItem).teamCity;
                string image = ((NBATeamModel)this.teamsAvailable.SelectedItem).teamImagePath;
                string teamChoice = city + " " + name;

                App.favoriteTeam = teamChoice;
                //ApplicationDataContainer appSettings = ApplicationData.Current.LocalSettings;
                //if (!appSettings.Containers.ContainsKey("favoriteTeam"))
                //{
                //    appSettings.Values.Add("favoriteTeam", teamChoice);
                //}
                //else
                //{
                //    appSettings.Values["favoriteTeam"] = teamChoice;
                //}
            }
            Frame.Navigate(typeof(MainPage));   
        }
    }
}
