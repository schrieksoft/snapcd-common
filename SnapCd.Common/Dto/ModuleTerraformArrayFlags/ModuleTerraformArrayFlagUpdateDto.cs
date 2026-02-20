using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleTerraformArrayFlags;

public class ModuleTerraformArrayFlagUpdateDto : ModuleTerraformArrayFlagCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
