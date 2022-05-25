using System;
using System.Collections.Generic;
using System.Text;

namespace GhostManga.Backend
{
    [Serializable]
    class SearchedMangeList
    {
        //makes a list of the searched manga object while also getting the info given from the API.
        public List<SearchedMange> mangaList { get; set; }
        public string numOfManga { get; set; }
        public string numOfPage { get; set; }
    }
}
