using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace blogger_graphQL
{
    public class BloggerMutation : ObjectGraphType
    {
        public BloggerMutation(IBlogData data)
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

            Field<BlogType>(
                "createBlogTest",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "blogContent" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "blogTitle" }
                ),
                resolve: context =>
                {
                    var blogContent = context.GetArgument<string>("blogContent");
                    var blogTitle = context.GetArgument<string>("blogTitle");
                    return data.CreateBlog(blogContent, blogTitle);
                });
        }
    }
}
