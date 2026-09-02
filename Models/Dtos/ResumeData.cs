namespace ResumeInBlazor.Models.Dtos;

public class ResumeData
{
    public string? Lang { get; init; }
    public Locale? Locale { get; init; }
    public Introduction Introduction { get; init; } = new();
    public List<Job> Jobs { get; init; } = [];
    public List<Project> Projects { get; init; } = [];
    public List<Programme> Education { get; init; } = [];
    public List<Certificate> Certificates { get; init; } = [];
    public List<SkillSet> SkillSets { get; init; } = [];
}
