using System;
using System.Collections.Generic;

namespace Nvh2310900042_lab11.Models;

public partial class NvhEmployee
{
    public long NvhEmpId { get; set; }

    public string? NvhEmpName { get; set; }

    public string? NvhEmpLevel { get; set; }

    public DateOnly? NvhEmpStartDate { get; set; }

    public bool? NvhEmpStatus { get; set; }
}
