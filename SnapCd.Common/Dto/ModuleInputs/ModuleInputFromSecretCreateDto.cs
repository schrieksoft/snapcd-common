using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromSecretCreateDto : ModuleInputCreateDto
{
    public Guid SecretId { get; set; }

    public InputType Type { get; set; }
}
