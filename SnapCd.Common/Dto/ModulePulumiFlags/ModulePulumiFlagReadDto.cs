using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModulePulumiFlags;

public class ModulePulumiFlagReadDto : ModulePulumiFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
