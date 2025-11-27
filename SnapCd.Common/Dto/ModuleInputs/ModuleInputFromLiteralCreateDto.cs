using SnapCd.Common.Dto.ModuleInputs.Base;

namespace SnapCd.Common.Dto.ModuleInputs;

public class ModuleInputFromLiteralCreateDto : ModuleInputCreateDto
{
    public string LiteralValue { get; set; } = null!;

    public InputType Type { get; set; }
}
