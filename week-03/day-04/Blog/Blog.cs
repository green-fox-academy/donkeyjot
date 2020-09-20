using System;
using System.Collections.Generic;

namespace Blog
{
    public class Blog
    {
        List<BlogPost> BlogList;

        public Blog()
        {
            BlogList = new List<BlogPost>();
        }

        public void Add(BlogPost post)
        {
            BlogList.Add(post);
        }

        public void Delete(int i)
        {
            BlogList.RemoveAt(i);
        }

        public void Update(int i, BlogPost post)
        {
            BlogList[i] = post;
        }
    
    }
}
