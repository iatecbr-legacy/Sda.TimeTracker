﻿namespace VstsRestApiSamples.ViewModels.Work
{
    public class PickListResponse
    {

        public class PickList : BaseViewModel
        {
            public Item[] items { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string value { get; set; }
        }

    }
}
