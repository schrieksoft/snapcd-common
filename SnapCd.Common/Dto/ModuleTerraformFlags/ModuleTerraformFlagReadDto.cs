using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleTerraformFlags;

public class ModuleTerraformFlagReadDto : ModuleTerraformFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
