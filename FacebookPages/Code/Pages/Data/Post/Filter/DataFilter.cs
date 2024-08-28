﻿using FacebookPages.Code.Pages.Data.Post.Sort;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookPages.Code.Pages.Data.Post.Sort.SortingMethod;

namespace FacebookPages.Code.Pages.Data.Post.Filter
{
    public class DataFilter
    {
        public User UserSource { get; set; }
        public List<User> AvailableUsersToSelect { get; set; } = new List<User>();
        public Dictionary<FilterMethod.eFilterCondition, bool> Conditions { get; set; } = 
            new Dictionary<FilterMethod.eFilterCondition, bool>();
        public DateTime MinDate { get; set; } = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public SortingMethod.eSortingMethod SortingMethod { get; set; } = Sort.SortingMethod.eSortingMethod.ByDatePublished;
        public bool ReverseOrder { get; set; } = false;
        public bool MatchAllFilters { get; set; } = false;
        public string TextContainsString { get; set; } = null;

        public static long ToUnixTimestamp(DateTime i_DateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(i_DateTime.ToUniversalTime());
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        public static DateTime FromUnixTimestamp(long i_UnixTimestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(i_UnixTimestamp);
            return dateTimeOffset.UtcDateTime;
        }
    }
}
