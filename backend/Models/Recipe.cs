using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Recipe
{
    [Key]
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string[] Ingredients { get; set; }

    public string Description { get; set; }

    public string Img { get; set; }

    public User User { get; set; }

    public string UserId { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime UpdatedAt { get; set; }
}

public class User
{
    [Key]
    public string Id { get; set; }
    public string userName { get; set; }
    
}

