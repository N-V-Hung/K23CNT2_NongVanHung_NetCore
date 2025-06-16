using NvhLesson09EF.Models;
using System;
using System.Collections.Generic;

namespace NvhLesson09EF.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}