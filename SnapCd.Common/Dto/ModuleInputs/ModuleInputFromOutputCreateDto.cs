using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputCreateDto : ModuleInputCreateDto
{
    public Guid OutputModuleId { get; set; }

    public string OutputName { get; set; } = null!;
}
