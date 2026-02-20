using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespacePulumiArrayFlags;

public class NamespacePulumiArrayFlagReadDto : NamespacePulumiArrayFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
