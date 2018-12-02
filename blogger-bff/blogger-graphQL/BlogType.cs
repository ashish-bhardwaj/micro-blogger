using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BlogType : ObjectGraphType<Blog>
    {
        public BlogType()
        {
            Field(b => b.Id).Description("The id of the blog.");
            Field(b => b.BlogTitle, nullable: false).Description("The title of the blog.");
            Field(b => b.BlogContent, nullable: false).Description("The content of the blog.");
        }
    }
}
