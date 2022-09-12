using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_and_Attributes
{
    [StereoDisc( "Thenmozhi","Tamizh")]
    public class Song
    {
        [StereoDisc("Gangsta's Paradise","English")]
        public string Name { get; set; }

        [StereoDisc("Ponni Nadhi" , "Tamizh")]
        public Song()
        {
            Console.WriteLine("Song Default Constructor");
        }
    }
}
