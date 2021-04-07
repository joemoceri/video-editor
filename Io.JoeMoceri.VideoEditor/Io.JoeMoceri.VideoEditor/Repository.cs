using System;
using System.Collections.Generic;

namespace VideoEditor
{
    public class Repository
    {
        public IEnumerable<VideoTask> GetVidyaTasksers()
        {
            return new List<VideoTask>
            {
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\dkc-tf-2.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            //Name = "test",
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-1-Harvest-Hazards",
                            StartTime = new TimeSpan(0, 42, 11),
                            EndTime = new TimeSpan(0, 53, 4)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-2-Reckless-Ride",
                            StartTime = new TimeSpan(1, 4, 2),
                            EndTime = new TimeSpan(1, 19, 13)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-3-Fruity-Factory",
                            StartTime = new TimeSpan(1, 9, 45),
                            EndTime = new TimeSpan(1, 17, 7)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-A-Beehive-Brawl",
                            StartTime = new TimeSpan(1, 18, 13),
                            EndTime = new TimeSpan(1, 34, 22)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-4-Panicky-Paddles",
                            StartTime = new TimeSpan(1, 36, 26),
                            EndTime = new TimeSpan(2, 21, 16)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-6-Frosty-Fruits",
                            StartTime = new TimeSpan(2, 44, 10),
                            EndTime = new TimeSpan(2, 56, 38)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-5-Boss-Punch-Bowl",
                            StartTime = new TimeSpan(3, 3, 6),
                            EndTime = new TimeSpan(3, 9, 54)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-1-Homecoming-Hijinxs",
                            StartTime = new TimeSpan(3, 11, 3),
                            EndTime = new TimeSpan(3, 32, 23)
                        },
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\dkc-tf-3.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-4-5-Sea-Stack-Attack",
                            StartTime = new TimeSpan(1, 47, 6),
                            EndTime = new TimeSpan(1, 52, 55)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-4-6-Current-Capers",
                            StartTime = new TimeSpan(1, 53, 36),
                            EndTime = new TimeSpan(2, 2, 9)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-4-Boss-Fugu-Face-Off",
                            StartTime = new TimeSpan(2, 33, 23),
                            EndTime = new TimeSpan(2, 37, 12)
                        },
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\dkc-tf-4.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-2-Seashore-War",
                            StartTime = new TimeSpan(0, 37, 31),
                            EndTime = new TimeSpan(0, 48, 34)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-3-Aqueduct-Assault",
                            StartTime = new TimeSpan(1, 1, 26),
                            EndTime = new TimeSpan(1, 5, 56)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-4-Blurry-Fury",
                            StartTime = new TimeSpan(1, 7, 3),
                            EndTime = new TimeSpan(1, 17, 51)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-5-Forest-Folly",
                            StartTime = new TimeSpan(1, 21, 56),
                            EndTime = new TimeSpan(1, 39, 56)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-6-Cliffside-Slide",
                            StartTime = new TimeSpan(1, 41, 5),
                            EndTime = new TimeSpan(1, 49, 39)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-7-Frozen-Frenzy",
                            StartTime = new TimeSpan(1, 50, 37),
                            EndTime = new TimeSpan(2, 8, 37)
                        },
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\dkc-tf-5.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-8-Meltdown-Mayhem",
                            StartTime = new TimeSpan(0, 1, 28),
                            EndTime = new TimeSpan(0, 17, 27)
                        },
                        new VideoTimeframe
                        {
                            Name = "Donkey-Kong-Country-Tropical-Freeze-6-Boss-Volcano-Dome Plus Credits",
                            StartTime = new TimeSpan(0, 46, 55),
                            EndTime = new TimeSpan(0, 57, 42)
                        }
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\borderlands-1.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "Borderlands 3 Shiv Fight",
                            StartTime = new TimeSpan(0, 29, 18),
                            EndTime = new TimeSpan(0, 30, 40)
                        }
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\sin-is-jecht.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "ha-ha-ha. . . .",
                            StartTime = new TimeSpan(0, 0, 0),
                            EndTime = new TimeSpan(0, 0, 34)
                        }
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\before-yunalesca-fight.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "uraaaagaaaaahhhh. . . .",
                            StartTime = new TimeSpan(0, 1, 29),
                            EndTime = new TimeSpan(0, 2, 29)
                        }
                    }
                },
            };
        }

        public IEnumerable<VideoTask> GetVideoTaskz()
        {
            return new List<VideoTask>
            {
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\rush-afterimage.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "solo",
                            StartTime = new TimeSpan(0, 2, 20),
                            EndTime = new TimeSpan(0, 3, 20)
                        },
                    }
                }
            };
        }
        public IEnumerable<VideoTask> GetVideoTasks()
        {
            return new List<VideoTask>
            {
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\mega-man-x-playthrough.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        new VideoTimeframe
                        {
                            Name = "chill-penguin",
                            StartTime = new TimeSpan(0, 14, 0),
                            EndTime = new TimeSpan(0, 15, 35)
                        },
                        new VideoTimeframe
                        {
                            Name = "spark-mandrill",
                            StartTime = new TimeSpan(0, 28, 10),
                            EndTime = new TimeSpan(0, 29, 6)
                        },
                        new VideoTimeframe
                        {
                            Name = "armored-armadillo",
                            StartTime = new TimeSpan(0, 35, 33),
                            EndTime = new TimeSpan(0, 37, 7)
                        },
                        new VideoTimeframe
                        {
                            Name = "launch-octopus",
                            StartTime = new TimeSpan(0, 47, 20),
                            EndTime = new TimeSpan(0, 49, 13)
                        },
                        new VideoTimeframe
                        {
                            Name = "boomer-kuwanger",
                            StartTime = new TimeSpan(0, 58, 38),
                            EndTime = new TimeSpan(0, 59, 43)
                        },
                        new VideoTimeframe
                        {
                            Name = "sting-chameleon",
                            StartTime = new TimeSpan(1, 6, 7),
                            EndTime = new TimeSpan(1, 7, 16)
                        },
                        new VideoTimeframe
                        {
                            Name = "storm-eagle",
                            StartTime = new TimeSpan(1, 13, 42),
                            EndTime = new TimeSpan(1, 14, 40)
                        },
                        new VideoTimeframe
                        {
                            Name = "flame-mammoth",
                            StartTime = new TimeSpan(1, 19, 20),
                            EndTime = new TimeSpan(1, 20, 20)
                        },
                        new VideoTimeframe
                        {
                            Name = "vile",
                            StartTime = new TimeSpan(1, 46, 54),
                            EndTime = new TimeSpan(1, 50, 21)
                        },
                        new VideoTimeframe
                        {
                            Name = "bossspider",
                            StartTime = new TimeSpan(1, 55, 50),
                            EndTime = new TimeSpan(1, 58, 58)
                        },
                        new VideoTimeframe
                        {
                            Name = "rangda-bangda",
                            StartTime = new TimeSpan(2, 28, 24),
                            EndTime = new TimeSpan(2, 31, 48)
                        },
                        new VideoTimeframe
                        {
                            Name = "d-rex",
                            StartTime = new TimeSpan(2, 42, 10),
                            EndTime = new TimeSpan(2, 44, 42)
                        },
                        new VideoTimeframe
                        {
                            Name = "sigma-stage-4",
                            StartTime = new TimeSpan(3, 14, 20),
                            EndTime = new TimeSpan(3, 22, 5)
                        },
                    },
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\mega-man-x2-playthrough.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        CreateVideoTimeframe("wire-sponge", 
                        new TimeSpan(0, 37, 44), 
                        new TimeSpan(0, 40, 35)),
                        CreateVideoTimeframe("wheel-gator",
                        new TimeSpan(0, 49, 26),
                        new TimeSpan(0, 52, 46)),
                        CreateVideoTimeframe("violen",
                        new TimeSpan(0, 58, 49),
                        new TimeSpan(0, 59, 59)),
                        CreateVideoTimeframe("serges",
                        new TimeSpan(1, 17, 43),
                        new TimeSpan(1 , 19, 15)),
                        CreateVideoTimeframe("overdrive-ostrich",
                        new TimeSpan(1, 22, 51),
                        new TimeSpan(1, 24, 34)),
                        CreateVideoTimeframe("bubble-crab",
                        new TimeSpan(1, 55, 44),
                        new TimeSpan(1, 57, 8)),
                        CreateVideoTimeframe("flame-stag",
                        new TimeSpan(2, 11, 55),
                        new TimeSpan(2, 13, 14)),
                        CreateVideoTimeframe("morph-moth",
                        new TimeSpan(2, 22, 33),
                        new TimeSpan(2, 24, 3)),
                        CreateVideoTimeframe("magna-centipede",
                        new TimeSpan(2, 42, 52),
                        new TimeSpan(2, 46, 3)),
                        CreateVideoTimeframe("crystal-snail",
                        new TimeSpan(3, 4, 27),
                        new TimeSpan(3, 6, 6)),
                        CreateVideoTimeframe("violen-2",
                        new TimeSpan(3, 43, 14),
                        new TimeSpan(3, 44, 25)),
                        CreateVideoTimeframe("serges-2",
                        new TimeSpan(3, 53, 8),
                        new TimeSpan(3, 54, 46)),
                        CreateVideoTimeframe("agile",
                        new TimeSpan(4, 1, 53),
                        new TimeSpan(4, 5, 8)),
                        CreateVideoTimeframe("zero",
                        new TimeSpan(4, 33, 49),
                        new TimeSpan(4, 36, 18)),
                        CreateVideoTimeframe("sigma",
                        new TimeSpan(4, 36, 33),
                        new TimeSpan(4, 37, 49)),
                        CreateVideoTimeframe("neo-sigma",
                        new TimeSpan(4, 37, 57),
                        new TimeSpan(4, 44, 20)),
                    }
                },
                new VideoTask
                {
                    FilePath = @"C:\Users\Joe Moceri\Source\Repos\VideoEditor\VideoEditor\Videos\mega-man-x3-playthrough.mp4",
                    VideoTimeframes = new List<VideoTimeframe>
                    {
                        CreateVideoTimeframe("blizzard-buffalo",
                        new TimeSpan(0, 37, 6),
                        new TimeSpan(0, 39, 4)
                        ),
                        CreateVideoTimeframe("toxic-seahorse",
                        new TimeSpan(0, 43, 12),
                        new TimeSpan(0, 44, 15)
                        ),
                        CreateVideoTimeframe("bit",
                        new TimeSpan(1, 2, 35),
                        new TimeSpan(1, 3, 45)
                        ),
                        CreateVideoTimeframe("tunnel-rhino",
                        new TimeSpan(1, 19, 30),
                        new TimeSpan(1, 20, 41)
                        ),
                        CreateVideoTimeframe("volt-catfish",
                        new TimeSpan(1, 26, 8),
                        new TimeSpan(1, 27, 20)
                        ),
                        CreateVideoTimeframe("crush-crawfish",
                        new TimeSpan(1, 32, 26),
                        new TimeSpan(1, 33, 37)
                        ),
                        CreateVideoTimeframe("neon-tiger",
                        new TimeSpan(1, 42, 53),
                        new TimeSpan(1, 44, 28)
                        ),
                        CreateVideoTimeframe("byte",
                        new TimeSpan(1, 47, 48),
                        new TimeSpan(1, 49, 27)
                        ),
                        CreateVideoTimeframe("gravity-beetle",
                        new TimeSpan(1, 53, 1),
                        new TimeSpan(1, 54, 5)
                        ),
                        CreateVideoTimeframe("blast-hornet",
                        new TimeSpan(1, 58, 56),
                        new TimeSpan(2, 0, 20)
                        ),
                        CreateVideoTimeframe("press-disposer",
                        new TimeSpan(2, 25, 10),
                        new TimeSpan(2, 28, 10)
                        ),
                        CreateVideoTimeframe("vile",
                        new TimeSpan(2, 33, 11),
                        new TimeSpan(2, 36, 42)
                        ),
                        CreateVideoTimeframe("dr-doppler",
                        new TimeSpan(2, 51, 19),
                        new TimeSpan(2, 54, 34)
                        ),
                        CreateVideoTimeframe("sigma",
                        new TimeSpan(3, 34, 18),
                        new TimeSpan(3, 35, 13)
                        ),
                        CreateVideoTimeframe("kaiser-sigma",
                        new TimeSpan(3, 35, 15),
                        new TimeSpan(3, 42, 7)
                        ),
                    }
                }
            };
        }

        private VideoTimeframe CreateVideoTimeframe(string name, TimeSpan startTime, TimeSpan endTime)
        {
            return new VideoTimeframe
            {
                Name = name,
                StartTime = startTime,
                EndTime = endTime
            };
        }
    }
}
