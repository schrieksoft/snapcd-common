using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromLiteralUpdateDto : ModuleInputFromLiteralCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
