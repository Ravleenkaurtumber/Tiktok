using System;
using System.Collections.Generic;
using System.Text;

namespace TikTok
{
    class TikTok
    {
        static int _ID;
        public string Originator { get; }
        public int Length { get; }
        public string Hashtag { get; }
        public string Audience { get; }
        public string Id { get; }


        public TikTok(string originator, int length, string hashtag, Audience audience)
        {
            Originator = originator;
            Length = length;
            Hashtag = hashtag;
            Id = _ID;
            _ID++;
        }
        private TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {
            Id = id;
            Length = length;
            Hashtag = hashTag;
            Originator = originator;

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static TikTok Parse(string line)
        {
            string[] words = line.Split("\t");
            foreach(string word in words)
            {
            
            }
            
                
            
        }
    }
}
