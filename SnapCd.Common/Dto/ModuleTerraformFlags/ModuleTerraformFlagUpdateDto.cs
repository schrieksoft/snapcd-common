using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleTerraformFlags;

public class ModuleTerraformFlagUpdateDto : ModuleTerraformFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
