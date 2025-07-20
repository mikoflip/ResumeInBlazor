using System;

namespace ResumeInBlazor.Models.ViewModels;

public class Certificate
{
    public string? Title { get; set; }
    public string? Issuer { get; set; }
    public DateOnly? IssueDate { get; set; }
    public string? Id { get; set; }
    public string? Url { get; set; }
}