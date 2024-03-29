﻿using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class PostAttachment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid PostId { get; set; }

        public Post Post { get; set; }

        public DateTime Created { get; set; }

        [Required]
        public String Path { get; set; }
    }
}
