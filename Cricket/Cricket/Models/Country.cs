﻿using System;
using System.Collections.Generic;

namespace Cricket.Models
{
    public partial class Country
    {
        public Country()
        {
            MatchesTeamANavigation = new HashSet<Matches>();
            MatchesTeamBNavigation = new HashSet<Matches>();
            Player = new HashSet<Player>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public string CountryCode { get; set; }

        public Stadium Stadium { get; set; }
        public ICollection<Matches> MatchesTeamANavigation { get; set; }
        public ICollection<Matches> MatchesTeamBNavigation { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}
