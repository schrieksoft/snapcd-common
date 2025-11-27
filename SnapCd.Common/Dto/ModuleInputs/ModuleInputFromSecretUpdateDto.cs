using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromSecretUpdateDto : ModuleInputFromSecretCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
