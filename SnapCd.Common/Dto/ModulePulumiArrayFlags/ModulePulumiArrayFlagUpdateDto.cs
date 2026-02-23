using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModulePulumiArrayFlags;

public class ModulePulumiArrayFlagUpdateDto : ModulePulumiArrayFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
