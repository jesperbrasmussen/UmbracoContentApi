﻿using System.Collections.Generic;

namespace UmbracoContentApi.Models
{
    public class EntryModel
    {
        public SystemModel System { get; set; }
        public Dictionary<string, object> Fields { get; set; }
    }
}