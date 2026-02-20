using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespacePulumiFlags;

public class NamespacePulumiFlagUpdateDto : NamespacePulumiFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
