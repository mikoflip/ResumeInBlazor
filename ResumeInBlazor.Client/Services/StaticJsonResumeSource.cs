using System.Net.Http.Json;
using ResumeInBlazor.Models.Dtos;

namespace ResumeInBlazor.Services;

/// <summary>
/// Reads the resume from a static JSON file shipped in wwwroot, preserving the
/// app's original data-loading behavior.
/// </summary>
public sealed class StaticJsonResumeSource(HttpClient httpClient) : IResumeSource
{
    // Static resume file under wwwroot. Moves to configuration once multiple
    // locales / a resume API are introduced.
    private const string ResumeJsonPath = "json/MockDataNL.json";

    public Task<ResumeData?> GetResumeAsync(CancellationToken cancellationToken = default)
        => httpClient.GetFromJsonAsync<ResumeData>(ResumeJsonPath, cancellationToken);
}
