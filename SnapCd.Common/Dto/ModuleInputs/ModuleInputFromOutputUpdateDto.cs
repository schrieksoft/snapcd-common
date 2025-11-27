using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputUpdateDto : ModuleInputFromOutputCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
