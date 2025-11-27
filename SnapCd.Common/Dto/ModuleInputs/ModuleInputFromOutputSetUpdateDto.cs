using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromOutputSetUpdateDto : ModuleInputFromOutputSetCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
