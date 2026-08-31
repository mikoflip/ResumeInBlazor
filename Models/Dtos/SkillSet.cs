using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Models.Dtos;

public class SkillSet : IPrintBreakable, IHideable
{
    public string? Title { get; set; }
    public string[]? Skills { get; set; }
    public bool PageBreakBefore { get; set; }
    public bool Hidden { get; set; }
}