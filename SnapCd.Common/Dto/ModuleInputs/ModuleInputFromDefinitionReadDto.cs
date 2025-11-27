using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromDefinitionReadDto : ModuleInputFromDefinitionCreateDto, IDto
{
    public Guid Id { get; set; }
}