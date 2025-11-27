using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputSetReadDto : ModuleInputFromOutputSetCreateDto, IDto
{
    public Guid Id { get; set; }
}