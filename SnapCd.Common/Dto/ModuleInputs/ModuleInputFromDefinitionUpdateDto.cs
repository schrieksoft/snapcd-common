using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromDefinitionUpdateDto : ModuleInputFromDefinitionCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
