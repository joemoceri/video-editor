# video-editor

> This is an application written in C# .NET 5 that use's MediaToolkit and VideoLibrary to do video processing and operations such as downloading youtube videos, converting to .mp3, and clipping video files.

* [Overview](#overview)
* [Usage](#usage)

<a name="overview"></a>
## Overview
This is a project written in C# that will, given a math, string or boolean expression, evaluate it using a built-in Language Template called EE Expressions. Language Templates are what the Expression Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on.  EE Expressions is influenced by Python syntax by default, but the operations are fully customizable. Using this Language Template you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic.

Not Supported:
 * Single quotes (') as strings. You must use double quotes (") for strings. You can still use single quotes inside strings, and escaped double quotes.
 * Customizing what defines a quote, a parentheses (())

For example, if you have an expression in C# like '1 > 2', it will return 'False', with a type of Boolean. You can hook into the '>' operator with the following methods: OnBeforeOperatorExpressionSolved (before the expression is solved), OnAfterOperatorExpressionSolved (after the expression is solved), SolveOperatorExpression (override the default behaviour and solve it yourself). You can also customize the operator to use 'greater-than' as an operator instead of '>', so that '1 greater-than 2' will return 'False' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called ExpressionResult that contains the value, variable type, and error, if any. Please see Usage for examples.

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
```
