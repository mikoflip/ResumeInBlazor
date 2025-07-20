namespace ResumeInBlazor.Models.ViewModels;

public class Job
{
    public string? Title { get; set; }
    public string? Employer { get; set; }
    public string? Location { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string[]? Responsibilities { get; set; }
    public Reference? Reference { get; set; }
}