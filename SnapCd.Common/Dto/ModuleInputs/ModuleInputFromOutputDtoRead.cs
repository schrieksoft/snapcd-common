using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputDtoRead : ModuleInputFromOutputCreateDto, IDto
{
    public Guid Id { get; set; }
}