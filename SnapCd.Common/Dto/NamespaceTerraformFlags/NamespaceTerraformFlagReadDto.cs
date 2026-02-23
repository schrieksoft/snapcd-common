using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.NamespaceTerraformFlags;

public class NamespaceTerraformFlagReadDto : NamespaceTerraformFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
