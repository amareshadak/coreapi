using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COREAPI.Domain;

namespace COREAPI.Services
{
    public class PostService : IPostService
    {
        private readonly List<Post> _posts;
        public PostService()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid(), Name = $"post no {i}" });
            }
        }

        public Post GetPostById(Guid postId)
        {
            return _posts.FirstOrDefault(p => p.Id == postId);
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }
    }
}
