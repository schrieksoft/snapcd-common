using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromDefinitionCreateDto : ModuleInputCreateDto
{
    public DefinitionInputType DefinitionName { get; set; }
}
