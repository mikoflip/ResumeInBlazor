using System;

namespace ResumeInBlazor.Models.ViewModels;

public class Project
{
    public string? Title { get; set; }
    public string? Client { get; set; }
    public string? Location { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string[]? Responsibilities { get; set; }
    public Reference? Reference { get; set; }
    public string? Url { get; set; }
    public string? Github { get; set; }
}