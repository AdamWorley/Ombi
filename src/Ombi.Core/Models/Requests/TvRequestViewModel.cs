﻿using System.Collections.Generic;

namespace Ombi.Core.Models.Requests
{
    public class TvRequestViewModel
    {
        public bool RequestAll { get; set; }
        public bool LatestSeason { get; set; }
        public bool FirstSeason { get; set; }
        public int TvDbId { get; set; }
        public List<SeasonsViewModel> Seasons { get; set; } = new List<SeasonsViewModel>();
    }

    public class SeasonsViewModel
    {
        public int SeasonNumber { get; set; }
        public List<EpisodesViewModel> Episodes { get; set; } = new List<EpisodesViewModel>();
    }

    public class EpisodesViewModel
    {
        public int EpisodeNumber { get; set; }
    }

}