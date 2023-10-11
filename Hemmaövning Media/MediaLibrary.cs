using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemmaövning_Media
{
    internal static class MediaLibrary
    {
        private static List<Media> LibraryList = new List<Media>();
        internal static void AddMedia(Media media)
        {
            LibraryList.Add(media); 
        }

        internal static void DisplayAllMedia()
        {
            foreach (Media media in LibraryList)
            {
                media.DisplayInfo();
            }
        }
    }
}
