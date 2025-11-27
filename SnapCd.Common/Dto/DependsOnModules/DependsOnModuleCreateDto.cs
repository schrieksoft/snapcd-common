namespace SnapCd.Common.Dto.DependsOnModules;

/// <summary>
/// DTO for creating a new DependsOnModule (POST operations).
/// </summary>
public class DependsOnModuleCreateDto
{
    public Guid ModuleId { get; set; }

    public Guid DependsOnModuleId { get; set; }
}
