using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputSetCreateDto : ModuleInputCreateDto
{
    public Guid OutputModuleId { get; set; }
}
