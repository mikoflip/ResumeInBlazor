using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Models.Dtos;

public class Programme : IPrintBreakable, IHideable
{
    public string? Title { get; set; }
    public string? Institute { get; set; }
    public string? Location { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string[]? Extracurriculars { get; set; }
    public bool PageBreakBefore { get; set; }
    public bool Hidden { get; set; }
}