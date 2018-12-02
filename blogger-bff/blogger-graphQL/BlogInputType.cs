using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BlogInputType : InputObjectGraphType<Blog>
    {
        public BlogInputType()
        {
            Name = "BlogInput";
            Field(x => x.BlogTitle);
            Field(x => x.BlogContent);
        }
    }
}
