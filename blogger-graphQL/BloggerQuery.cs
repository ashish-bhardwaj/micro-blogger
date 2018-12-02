using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BloggerQuery: ObjectGraphType <object>
    {
        public BloggerQuery(BlogData data)
        {
            Name = "Query";
            Field<BlogType>("blog", arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the blog" }
                ),
                resolve: context => data.GetBlogByIdAsync(context.GetArgument<string>("id"))
                );
        }
    }
}
