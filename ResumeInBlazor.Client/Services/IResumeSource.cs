using ResumeInBlazor.Models.Dtos;

namespace ResumeInBlazor.Services;

/// <summary>
/// Loads the full resume document. The current implementation reads a static
/// JSON file shipped in wwwroot; a later one will resolve it against a resume
/// API backed by Cosmos DB. Callers hold no knowledge of the underlying source.
/// </summary>
public interface IResumeSource
{
    Task<ResumeData?> GetResumeAsync(CancellationToken cancellationToken = default);
}
