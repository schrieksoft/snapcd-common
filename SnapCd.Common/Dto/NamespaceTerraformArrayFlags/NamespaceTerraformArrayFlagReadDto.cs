using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceTerraformArrayFlags;

public class NamespaceTerraformArrayFlagReadDto : NamespaceTerraformArrayFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
