using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModulePulumiArrayFlags;

public class ModulePulumiArrayFlagReadDto : ModulePulumiArrayFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
