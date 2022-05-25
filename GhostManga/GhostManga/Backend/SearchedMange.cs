using System;
using System.Collections.Generic;
using System.Text;

namespace GhostManga.Backend
{
    [Serializable]
    class SearchedMange
    {
        //When a search is made with the API, not all of the mangas info is given. This is a object of the info that is given.
        public string mangaID { get; set; }
        public string mangaRate { get; set; }
        public string mangaName { get; set; }
        public string mangaFollower { get; set; }
        public string mangaViews { get; set; }
        public string mangaImg { get; set; }
        public string mangaDes { get; set; }
    }
}
