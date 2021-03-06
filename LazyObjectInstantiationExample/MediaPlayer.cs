﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiationExample
{
    public class MediaPlayer
    {
        public void Play() { /* Play a song */ }
        public void Pause() { /* Pause the song */ }
        public void Stop() { /* Stop playback */ }
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>();
        public AllTracks GetAllTracks()
        {
            return allSongs.Value;
        }
    }
}
