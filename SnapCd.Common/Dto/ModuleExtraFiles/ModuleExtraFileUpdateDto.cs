using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleExtraFiles;

/// <summary>
/// DTO for updating an existing ModuleExtraFile (PUT operations).
/// </summary>
public class ModuleExtraFileUpdateDto : ModuleExtraFileCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
