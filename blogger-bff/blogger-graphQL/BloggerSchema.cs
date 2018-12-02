using GraphQL;
using GraphQL.Types;
using System;

namespace blogger_graphQL
{
    public class BloggerSchema : Schema
    {
        public BloggerSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<BloggerQuery>();
            Mutation = resolver.Resolve<BloggerMutation>();
        }
    }
}
