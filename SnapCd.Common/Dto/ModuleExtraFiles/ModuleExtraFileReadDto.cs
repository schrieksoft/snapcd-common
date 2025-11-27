using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleExtraFiles;

/// <summary>
/// DTO for ModuleExtraFile responses (GET operations).
/// </summary>
public class ModuleExtraFileReadDto : ModuleExtraFileCreateDto, IDto
{
    public Guid Id { get; set; }
}
