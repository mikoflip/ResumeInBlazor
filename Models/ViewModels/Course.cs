namespace ResumeInBlazor.Models.ViewModels;

public class Course
{
    public string? Title { get; set; }
    public string? Institute { get; set; }
    public string? Location { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string[]? Extracurriculars { get; set; }
}