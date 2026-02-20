using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleTerraformArrayFlags;

public class ModuleTerraformArrayFlagReadDto : ModuleTerraformArrayFlagCreateDto, IDto
{
    public Guid Id { get; set; }
}
