﻿using Blog.Common.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Server.Authorization;

namespace Blog.Common.Model.ViewModel
{
    public class PostModel : IOwnerObject
    {
        public int? PostID { get; set; }
        [MinLength(5), MaxLength(200)]
        [Required]
        public string PostTitle { get; set; }
        [MaxLength(1000)]
        public string? PostDetails { get; set; }
        public int BlogID { get; set; }
        public string? BlogTitle { get; set; }
        public string PostOwnerID { get; set; }
        public string? ObjectOwnerId { get; set; }
        public string? Tags { get; set; }
        public List<string>? TagsList { get; set; }
        public string? UserName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? FileName { get; set; }
    }
}
