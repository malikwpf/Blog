﻿using PagedList.Core;
using QuiqBlog.Data.Models;

namespace QuiqBlog.Models.HomeViewModels {
    public class IndexViewModel {
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}