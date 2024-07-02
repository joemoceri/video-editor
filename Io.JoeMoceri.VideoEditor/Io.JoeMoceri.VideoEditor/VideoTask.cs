using System;
using System.Collections.Generic;
using System.IO;

namespace VideoEditor
{
    public class VideoTask
    {
        public string Name => Path.GetFileNameWithoutExtension(FilePath);
        public string FilePath { get; set; }

        public IEnumerable<VideoTimeframe> VideoTimeframes { get; set; }
    }

    public class VideoTimeframe
    {
        public string Name { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }
        public TimeSpan Length { get { return EndTime - StartTime; } }
    }
}
