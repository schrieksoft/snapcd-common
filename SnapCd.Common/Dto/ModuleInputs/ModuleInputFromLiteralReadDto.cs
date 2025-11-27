using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromLiteralReadDto : ModuleInputFromLiteralCreateDto, IDto
{
    public Guid Id { get; set; }
}