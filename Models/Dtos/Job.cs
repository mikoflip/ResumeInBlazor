using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Models.Dtos;

public class Job : IPrintBreakable, IHideable
{
    public string? Title { get; set; }
    public string? Employer { get; set; }
    public string? Location { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string? EndDateReplacement { get; set; }
    public string[]? Responsibilities { get; set; }
    public Reference? Reference { get; set; }
    public bool PageBreakBefore { get; set; }
    public bool Hidden { get; set; }
}