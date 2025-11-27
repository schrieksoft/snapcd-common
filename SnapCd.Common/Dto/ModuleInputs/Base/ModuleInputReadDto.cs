using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs.Base;

public class ModuleInputReadDto : ModuleInputCreateDto, IDto
{
    public Guid Id { get; set; }
}