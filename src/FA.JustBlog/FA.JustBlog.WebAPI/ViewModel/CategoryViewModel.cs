﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FA.JustBlog.WebAPI.ViewModel
{
    public class CategoryViewModel : BasicViewModel
    {
        public string Name { get; set; }

        public string UrlSlug { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime InsertedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}