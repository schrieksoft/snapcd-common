using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespacePulumiFlags;

public class NamespacePulumiFlagReadDto : NamespacePulumiFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
