//This is what does into each individual manga and all its details.
using System;

namespace GhostManga.Backend
{
    [Serializable]
    class INDIVMangaDetails
    {
        public string mangaID { get; set; }
        public string mangaName { get; set; }

        //Since it is possable for a manga to have many names the API displays all the names as a list.
        //might not be necessary until support for multiple languages
        public string[] mangaAltNames { get; set; }
        public string mangaAuthor { get; set; }

        //Since it is possable for a manga to have several genre the API displays all the genres as a list.
        public string[] mangaGenre { get; set; }
        public string mangaRateScore { get; set; }
        public string mangaStatus { get; set; }
        public string mangaViews { get; set; }
        public string mangaChapterNumber { get; set; }
        public string mangaDescription { get; set; }
        public string mangaImageLink { get; set; }
        //each chatper is its own object so a list is made to hold all the chapters and its data.
        public INDIVMangaChapter[] chapters { get; set; }
    }
}
