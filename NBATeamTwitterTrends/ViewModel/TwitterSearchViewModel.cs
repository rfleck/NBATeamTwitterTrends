using NBATeamTwitterTrends.Model;
using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBATeamTwitterTrends.ViewModel
{
    public class TwitterSearchViewModel
    {
        public List<NBATeamTweet> tweetList { get; set; }
        
        public async Task OpenTwitterConnection(string findString, int findLimit)
        {
            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = App.consumerKey, 
                    ConsumerSecret = App.consumerSecret,
                    AccessToken = App.accessToken,
                    AccessTokenSecret = App.acessTokenSecret
                }
            };
            TwitterContext twitterCtx = new TwitterContext(auth);
            Search searchResponse = await (
                                    from   search
                                    in     twitterCtx.Search
                                    where  search.Type       == SearchType.Search &&
                                           search.Query      == findString        &&
                                           search.Count      == findLimit         &&
                                           search.ResultType == ResultType.Recent
                                    select search
                                    ).SingleOrDefaultAsync();

            if (searchResponse != null && searchResponse.Statuses != null)
            {
                this.tweetList = new List<NBATeamTweet>();
                List<Status> searchResults = searchResponse.Statuses.ToList();
                foreach (var tweet in searchResults)
                {
                    tweet.IncludeRetweets = false;
                    tweet.IncludeUserEntities = true;
                    tweet.User.ShowAllInlineMedia = true;
                    tweet.User.ImageSize = ProfileImageSize.Normal;
                    tweetList.Add(new NBATeamTweet() { tweetUser = tweet.User.ScreenNameResponse , tweetContent = tweet.Text, tweetImage = tweet.User.ProfileImageUrl });
                }
            }
        }
    }
}
