using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespacePulumiArrayFlags;

public class NamespacePulumiArrayFlagUpdateDto : NamespacePulumiArrayFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
