using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GhostManga.Backend
{
    class SearchClass
    {
        public SearchedMangeList SB = new SearchedMangeList();
        public void GetSearchList(string sWord, string sType, string page)
        {
            SB = mainsearch(sWord, sType, page);
        }
        //takes the input to create the API URL that will access a json file of the what was found in the search.
        static SearchedMangeList mainsearch(string sWord, string sType, string page)
        {
            //APIkeys will need to maed on your own
            APIkeys a = new APIkeys();
           
            //opens the json with the searched items
            WebClient c = new WebClient();
            string searchJson = c.DownloadString(a.SearchKey+ "type=" + sType + "&search=" + sWord + "&page=" + page);
            var search = JsonConvert.DeserializeObject<SearchedMangeList>(searchJson);
            //returned everything in the json as a object
            return search;
        }
    }
}
