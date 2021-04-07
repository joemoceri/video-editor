using BigOlUsefulVideoTool;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.IO;
using VideoEditor;
using VideoLibrary;

namespace Io.JoeMoceri.VideoEditor
{
    public class App
    {
        public void Run()
        {
            // convert to mp4, using .mkv, can use other formats
            //var path = @"C:\the-rest-of-your-path-to.mkv";
            //ConvertToMp4(path);

            var musicRequest = CreateMusicRequest("david-gilmour-coming-back-to-life", "https://www.youtube.com/watch?v=V6LFjel-EaA");

            // it will create a folder here for the video, store where you'd like, so something like 'C:\Users\{username}\Documents\music-downloads'
            var basePath = @"C:\Users\jmoce\Documents\music-downloads";
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

        private MusicRequest CreateMusicRequest(string name, string url)
        {
            return new MusicRequest
            {
                Name = name,
                Url = url
            };
        }

        private void ClipVideo(string folderPath, VideoTask videoTask)
        {
            var folder = folderPath;

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            foreach (var videoTimeframe in videoTask.VideoTimeframes)
            {
                var inputFile = new MediaFile { Filename = videoTask.FilePath };
                var outputFileName = Path.Combine(folder, $"{videoTimeframe.Name}.mp4");
                var outputFile = new MediaFile { Filename = outputFileName };

                if (File.Exists(outputFileName))
                {
                    Console.WriteLine($"{Path.GetFileName(outputFileName)} already exists");
                    continue;
                }

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    var options = new ConversionOptions();

                    options.CutMedia(videoTimeframe.StartTime, videoTimeframe.Length);
                    engine.Convert(inputFile, outputFile, options);
                }
            }
        }

        private void ConvertToMp4(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            var inputFile = new MediaFile { Filename = $"{fileName}" };

            // create it right next to it
            var outputFile = new MediaFile { Filename = $"{fileName.Replace(extension, string.Empty)}.mp4" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }
        }

        /// <summary>
        /// Use this to download youtube music
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="videoUrl"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string DownloadMusic(string folderPath, string videoUrl, string name)
        {
            Console.WriteLine($"('{name}')-Downloading...");
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(videoUrl);
            var extension = Path.GetExtension(vid.FullName);
            var fileName = Path.Combine(folderPath, $"{name}{extension}");

            if (File.Exists(fileName))
            {
                // nothing to do, return the path
                return fileName;
            }

            // otherwise create it
            Directory.CreateDirectory(folderPath);

            File.WriteAllBytes(fileName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = $"{fileName}" };
            var outputFile = new MediaFile { Filename = $"{fileName.Replace(extension, string.Empty)}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                Console.WriteLine($"('{name}')-Converting to mp3...");
                engine.Convert(inputFile, outputFile);
            }

            return fileName;
        }
    }
}
