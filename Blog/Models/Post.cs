﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string? Body { get; set; } string Empty = string.Empty;
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int AuthorId { get; set; }
        [Write(false)]
        public User? Author { get; set; }

        public int CategoryId { get; set; }
        [Write(false)]
        public Category? Category { get; set; }

        [Write(false)]
        public List<Tag> Tags { get; set; }
    }
}
