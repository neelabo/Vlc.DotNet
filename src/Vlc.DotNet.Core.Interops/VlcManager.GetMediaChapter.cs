﻿using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public int GetMediaChapter(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (disposedValue) throw new ObjectDisposedException(GetType().FullName);

            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return myLibraryLoader.GetInteropDelegate<GetMediaChapter>().Invoke(mediaPlayerInstance);
        }
    }
}
