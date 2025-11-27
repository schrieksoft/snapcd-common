using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs.Base;

public class ModuleInputUpdateDto : ModuleInputCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
