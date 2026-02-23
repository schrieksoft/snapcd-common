using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceTerraformArrayFlags;

public class NamespaceTerraformArrayFlagUpdateDto : NamespaceTerraformArrayFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
