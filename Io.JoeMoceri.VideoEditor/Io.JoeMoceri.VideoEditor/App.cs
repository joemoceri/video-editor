using HtmlAgilityPack;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using VideoLibrary;

namespace VideoEditor
{
    public class App
    {
        private readonly IOptions<ApplicationOptions> options;

        public App(IOptions<ApplicationOptions> options)
        {
            this.options = options;
        }

        public void Run()
        {
            // convert to mp4, using .mkv, can use other formats
            //var path = @"C:\the-rest-of-your-path-to.mkv";
            //ConvertToMp4(path);

            // get the bass entry
            var bassEntry = CreateBassRequest("Bob-Marley-Natural-Mystic", "https://www.youtube.com/watch?v=UZfaIx57UqU", "https://tabs.ultimate-guitar.com/tab/bob-marley/natural-mystic-bass-797396");

            // set the path
            var path = Path.Combine(options.Value.BasePath, bassEntry.Name);

            // download the video and get the file path to the video downloaded
            var filePath = DownloadVideo(path, bassEntry.VideoUrl, bassEntry.Name);

            // download the bass tab
            DownloadUltimateGuitarBassTab(bassEntry.BassTabUrl, path, bassEntry.Name);

            // clip the first 35 seconds
            ClipVideo(path, new VideoTask
            {
                FilePath = filePath,
                VideoTimeframes = new List<VideoTimeframe>
                {
                    new VideoTimeframe
                    {
                        Name = "first 35 seconds",
                        StartTime = new TimeSpan(0, 0, 0),
                        EndTime = new TimeSpan(0, 0, 35),
                    }
                }
            });
        }

        private string DownloadVideo(string folderPath, string videoUrl, string name)
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

        private BassRequest CreateBassRequest(string name, string videoUrl, string bassTabUrl)
        {
            return new BassRequest
            {
                Name = name,
                VideoUrl = videoUrl,
                BassTabUrl = bassTabUrl
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

        private void DownloadUltimateGuitarBassTab(string url, string path, string name)
        {
            Directory.CreateDirectory(path);

            var fileName = Path.Combine(path, $"{name}.bass-tab.html");
            using (var client = new WebClient())
            {
                client.DownloadFile(url, fileName);
            }

            var doc = new HtmlDocument();

            doc.Load(fileName);

            // remove scripts
            doc.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style" || n.Name == "img" || n.Name == "button" || n.Name == "ul" || n.Name == "li" || n.Name == "a" || n.Name == "h1"
                || n.Name == "h2" || n.Name == "h3" || n.Name == "h4" || n.Name == "h5" || n.Name == "h6" || n.Name == "ol" || n.Name == "input" || n.Name == "iframe" || n.Name == "select"
                || n.Name == "meta" || n.Name == "option" || n.Name == "ins" || n.Name == "textarea" || n.Name == "path")
                .ToList()
                .ForEach(n => n.Remove());

            var body = doc.DocumentNode.SelectSingleNode("/html/body");

            var text = body.OuterHtml;

            var jsStore = doc.DocumentNode.SelectSingleNode("/html/body/div[contains(@class, 'js-store')]");
            if (jsStore != null)
            {
                var val = HttpUtility.HtmlDecode(jsStore.Attributes["data-content"].Value);

                var obj = JObject.Parse(val);

                var token = obj.SelectToken("store.page.data.tab_view.wiki_tab.content");

                text = token.Value<string>();

                text = text.Replace("[tab]", "<pre>");
                text = text.Replace("[/tab]", "</pre>");
                text = text.Replace("\r\n", "<br />");
            }

            File.WriteAllText(fileName, text);
        }
    }
}
