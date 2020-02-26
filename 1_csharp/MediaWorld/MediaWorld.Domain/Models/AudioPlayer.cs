using System;

namespace MediaWorld.Domain.Models
{
    public class AudioPlayer 
    {
        private AudioPlayer() {}
        private static AudioPlayer _ap = new AudioPlayer();
        public static AudioPlayer Instance
        {
          get
          {
            return _ap;
          }
        }   
        public static AudioPlayer GetInstance()
        {
            return _ap;
        }
        
    }
}