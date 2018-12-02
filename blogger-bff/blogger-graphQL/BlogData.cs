using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogger_graphQL
{
    interface IBlogData
    {
        Task<Blog> GetBlogByIdAsync(String id);
    }

    public class BlogData : IBlogData
    {
        private readonly List<Blog> _blogs = new List<Blog>();

        public BlogData()
        {
            _blogs.Add(new Blog { Id = "1", BlogContent = "Blog Content 1", BlogTitle = "#1 Title" });
            _blogs.Add(new Blog { Id = "2", BlogContent = "Blog Content 2", BlogTitle = "#2 Title" });
            _blogs.Add(new Blog { Id = "3", BlogContent = "Blog Content 3", BlogTitle = "#3 Title" });
        }

        public Task<Blog> GetBlogByIdAsync(String id)
        {            
            return Task.FromResult(_blogs.FirstOrDefault(b => b.Id == id));
        }
    }
}
