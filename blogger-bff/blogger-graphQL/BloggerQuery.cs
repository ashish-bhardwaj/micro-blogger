using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BloggerQuery : ObjectGraphType<object>
    {
        public BloggerQuery(IBlogData data)
        {
            Name = "Query";

            Field<ListGraphType<BlogType>>("blogs",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "index", Description = "index of first entity." },
                    new QueryArgument<IntGraphType> { Name = "count", Description = "size of batch" }
                    ),
                resolve: context => data.GetBlogsAsync(
                    context.GetArgument<int>("index"),
                    context.GetArgument<int>("count")
                ));

            Field<BlogType>("blog",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>
                {
                    Name = "id",
                    Description = "id of the blog"
                }),
                resolve: context => data.GetBlogByIdAsync(
                    context.GetArgument<string>("id")
                ));
        }
    }
}
