﻿using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Models.Domain
{
    public class Franchise
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public ICollection<Movie>? Movies { get; set;}
    }
}
