using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModulePulumiFlags;

public class ModulePulumiFlagUpdateDto : ModulePulumiFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
