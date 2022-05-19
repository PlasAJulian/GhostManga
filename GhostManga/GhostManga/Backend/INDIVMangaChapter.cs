//This is what does into each individual chapter.
using System;

namespace GhostManga.Backend
{
    [Serializable]
    class INDIVMangaChapter
    {
        //the title of the chapter
        public string mangaChapterName { get; set; }
        //Each chapter is linked to a URL that has all the pages/images of the chapter.
        //this might be changed.
        public string mangaChapterLink { get; set; }
    }
}