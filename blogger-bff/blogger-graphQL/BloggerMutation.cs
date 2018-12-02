using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BloggerMutation : ObjectGraphType
    {
        public BloggerMutation(BlogData data)
        {
            Name = "Mutation";

            /*
             * mutation ex($blog:BlogInput!){
                  createBlog (blog: $blog){
                    id
                  }
                }

             *Variable:  {"blog":{"blogTitle": "TETETETTEE" , "blogContent": "Bade TETETETETTE"}}  
             */

            Field<BlogType>(
                "createBlog",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BlogInputType>> { Name = "blog" }
                ),
                resolve: context =>
                {
                    var blog = context.GetArgument<Blog>("blog");
                    return data.AddBlog(blog);
                });
        }
    }
}
