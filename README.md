# video-editor

> This is an application written in C# .NET 5 that use's MediaToolkit and VideoLibrary to do video processing and operations such as downloading youtube videos, converting to .mp3, and clipping video files.

* [Overview](#overview)
* [Usage](#usage)

<a name="overview"></a>
## Overview

This is an application written in C# .NET 5 that use's MediaToolkit and VideoLibrary to do video processing and operations such as downloading youtube videos, converting to .mp3, and clipping video files. It create's a folder where you specify and stores all the output there.

<a name="usage"></a>
## Usage

Please see App.cs for how to use.

```csharp
        public void Run()
        {
            // convert to mp4, using .mkv, can use other formats
            //var path = @"C:\the-rest-of-your-path-to.mkv";
            //ConvertToMp4(path);

            var musicRequest = CreateMusicRequest("david-gilmour-coming-back-to-life", "https://www.youtube.com/watch?v=V6LFjel-EaA");

            // it will create a folder here for the video, store where you'd like, so something like 'C:\Users\{username}\Documents\music-downloads'
            var basePath = @"C:\Users\{username}\Documents\music-downloads";
            var folderPath = Path.Combine(basePath, musicRequest.Name);
            var videoUrl = musicRequest.Url;
                
            // download music
            var filePath = DownloadMusic(folderPath, videoUrl, musicRequest.Name);

            // Clipping videos, specify a timespan and a name and it will output a file next to it called that
            ClipVideo(folderPath,
                new VideoTask
                {
                    FilePath = filePath,
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "my-favorite-part",
                            StartTime = new TimeSpan(0, 1, 59),
                            EndTime = new TimeSpan(0, 3, 20)
                        }
                    }
                });
        }
```
