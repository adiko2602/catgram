﻿namespace catgramAPI.Dtos
{
    public class PostDto
    {
        public IFormFile FormFile { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

