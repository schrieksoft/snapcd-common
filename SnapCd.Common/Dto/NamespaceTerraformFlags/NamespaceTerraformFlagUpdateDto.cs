using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceTerraformFlags;

public class NamespaceTerraformFlagUpdateDto : NamespaceTerraformFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
