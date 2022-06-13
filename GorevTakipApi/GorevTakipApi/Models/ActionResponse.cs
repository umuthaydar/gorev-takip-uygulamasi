﻿using System.Collections.Generic;

namespace GorevTakipApi.Models
{
    public class dataResult<data_class>
    {
        public long pageSize { get; set; } = 50;
        public long page { get; set; } = 1;
        public long itemCount { get; set; } = 1;
        public long totalItemCount { get; set; } = 1;
        public IEnumerable<data_class> items { get; set; }
    }

    public class apiResponse<data_class>
    {
        public bool success { get; set; } = false;
        public int httpCode { get; set; } = 200;
        public int code { get; set; } = 200;
        public string message { get; set; } = "";
        public string internalMessage { get; set; } = "";
        public dataResult<data_class> data { get; set; }
        public apiResponse()
        {
            data = new dataResult<data_class>();
        }
    }
}
