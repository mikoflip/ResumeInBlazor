using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Models.Dtos;

public class Project : IPrintBreakable, IHideable
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
    public bool PageBreakBefore { get; set; }
    public bool Hidden { get; set; }
}