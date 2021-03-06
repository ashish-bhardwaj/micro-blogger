﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogger_graphQL
{
    interface IBlogData
    {
        Task<Blog> GetBlogByIdAsync(String id);

        Task<List<Blog>> GetBlogsAsync(int index, int count);
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

        internal Blog AddBlog(Blog blog)
        {
            blog.Id = Guid.NewGuid().ToString();
            _blogs.Add(blog);
            return blog;
        }

        private List<Blog> getBlogs(int index, int count)
        {   
            return _blogs.GetRange(index, count);            
        }

        public Task<List<Blog>> GetBlogsAsync(int index, int count)
        {
            return Task.FromResult(getBlogs(index, count));
        }

        public Task<Blog> GetBlogByIdAsync(String id)
        {            
            return Task.FromResult(_blogs.FirstOrDefault(b => b.Id == id));
        }
    }
}
