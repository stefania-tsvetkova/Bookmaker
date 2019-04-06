﻿using System;

namespace Bookmaker.Data
{
    public static class Exceptions
    {
        public static string InvalidPersonName
            => "Invalid name for a person - it must contain only letters and can't be empty!";

        public static string InvalidAge
            => $"The age is invalid, it must be between {Constants.MinAge} and {Constants.MaxAge}!";

        public static string InvalidInjuryName
            => "Invalid name for an injury - it must contain only letters and can't be empty!";

        public static string InvalidTeamName
            => "Invalid name for a team - it must contain only letters and can't be empty!";

        public static string InvalidDivision 
            => $"Invalid division - it must be between 1 and {Constants.DivisionsCount}!";

        public static string InvalidBudget 
            => "The budget amount is invalid - it must be positive!";

        public static string InvalidId => "Invalid Id!";

        public static string NotOnSalePlayer => "Player is not on sale!";

        public static string MatchNotPlayed => "Match is not played yet!";

        public static string HostTeamNotCapableForAMatch =>
            $"Host team is not capable for a match - it must have {Constants.MinPlayersCountForAMatch} players or more!";

        public static string GuestTeamNotCapableForAMatch =>
            $"Guest team is not capable for a match - it must have {Constants.MinPlayersCountForAMatch} players or more!";

        public static string MatchHasAlreadyBeenPlayed => "Match has already been played!";
    }
}