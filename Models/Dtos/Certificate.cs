using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Models.Dtos;

public class Certificate : IPrintBreakable, IHideable
{
    public string? Title { get; set; }
    public string? Issuer { get; set; }
    public DateOnly? IssueDate { get; set; }
    public string? Id { get; set; }
    public string? Url { get; set; }
    public bool PageBreakBefore { get; set; }
    public bool Hidden { get; set; }
}