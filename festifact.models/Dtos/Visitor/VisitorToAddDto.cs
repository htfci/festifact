﻿using System;

namespace festifact.models.Dtos.Visitor;

public class VisitorToAddDto
{
    public int VisitorId { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? Sex { get; set; }

    public string? Residence { get; set; }

    public string? Email { get; set; }

    public int Password { get; set; }
}

