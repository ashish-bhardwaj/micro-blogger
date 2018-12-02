using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class Blog : BloggerEntity
    {
        public string BlogContent { get; set; }
        public string BlogTitle { get; set; }
    }
}
